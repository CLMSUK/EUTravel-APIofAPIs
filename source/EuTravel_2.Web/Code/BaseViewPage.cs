using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System;
using System.Linq;
using System.Xml;


namespace AppCode
{
    public class BaseViewPage<T> : System.Web.Mvc.WebViewPage<T>
    {
        private string _formName;

        public static string AppVersion { get; } = "1.0";

        public void Init(string formName)
        {
            _formName = formName;
        }

        public override void Execute()
        {
        }

        public string GetResource(string resourceKey)
        {
            return GetResourceValue(_formName, resourceKey);
        }

        public string GetGlobalResource(string resourceKey)
        {
            return GetResourceValue("GlobalResources", resourceKey);
        }

        public string GetContentWithVersion(string url)
        {
            return Url.Content(url + "?ver=" + AppVersion);
        }

        #region Locales

        private static Dictionary<string, XmlDocument> _cache = new Dictionary<string, XmlDocument>();
        private static List<string> _availiableLanguages = new List<string> { "en-us","el" };
        private static string _defaultLang = "en-us";

        public static XmlDocument GetLocales(string formName, string lang = null)
        {
            var cultureInfo = CultureInfo.GetCultureInfo("en-GB	");
            lang = string.IsNullOrWhiteSpace(lang)
                   ? cultureInfo.Name.ToLowerInvariant()
                   : lang;
            if (!_availiableLanguages.Contains(_defaultLang))
            {
                _defaultLang = _availiableLanguages[0];
            }
            if (!_availiableLanguages.Contains(lang))
            {
                try
                {
                    var bestMatch = _availiableLanguages.FirstOrDefault(l => l.Split('-').First() == lang.Split('-').First());
                    lang = bestMatch == null
                           ? _defaultLang
                           : bestMatch;
                }
                catch (Exception e)
                {
                    log4net.LogManager.GetLogger(nameof(GetLocales)).Error("Could not get best language match!", e);
                    lang = _defaultLang;
                }
            }
            var key = formName + "_" + lang;
            if (_cache.ContainsKey(key))
            {
                return _cache[key];
            }
            var doc = new XmlDocument();
            doc.LoadXml(GetResourceContents(key + "_res.xml"));
            if (lang != _defaultLang)
            {
                MergeWithDefaultResources(formName, doc);
            }
            if (!_cache.ContainsKey(key))
            {
                _cache.Add(key, doc);
            }
            return doc;
        }

        private static void MergeWithDefaultResources(string formName, XmlDocument doc)
        {
            var defaultResources = GetLocales(formName, _defaultLang);
            foreach (XmlElement node in defaultResources.SelectNodes("/Locales/Loc"))
            {
                var translated = doc.SelectSingleNode("/Locales/Loc[@Key='" + node.GetAttribute("Key") + "']");
                if (string.IsNullOrWhiteSpace(translated?.Attributes["Value"]?.Value))
                {
                    var imported = doc.ImportNode(node, true) as XmlElement;
                    doc.DocumentElement.AppendChild(imported);
                    if (translated != null)
                    {
                        doc.DocumentElement.RemoveChild(translated);
                    }
                }
            }
        }

        public static string GetResourceValue(string formName, string name)
        {
            var xml = GetLocales(formName);
            var node = xml.DocumentElement.SelectSingleNode("/Locales/Loc[@Key='" + name + "']");
            return node?.Attributes["Value"]?.Value ?? "";
        }

        private static string GetResourceContents(string fullPath)
        {
            return File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/Locales/" + fullPath));
        }

        public XmlDocument PrepareResources(string form, string master, bool addGlobal = true)
        {
            var resources = GetLocales(form);
            if (!string.IsNullOrWhiteSpace(master))
            {
                // Merge Master Page Resources
                var masterResources = GetLocales(master);
                foreach (XmlElement node in masterResources.SelectNodes("//Loc"))
                {
                    var copied = resources.ImportNode(node, true) as XmlElement;
                    copied.SetAttribute("Key", "MASTER_" + copied.GetAttribute("Key"));
                    resources.DocumentElement.AppendChild(copied);
                }
            }
            if (addGlobal)
            {
                // Merge Global Resources
                var globalResources = GetLocales("GlobalResources");
                foreach (XmlElement node in globalResources.SelectNodes("//Loc"))
                {
                    var copied = resources.ImportNode(node, true) as XmlElement;
                    copied.SetAttribute("Key", "GLOBAL_" + copied.GetAttribute("Key"));
                    resources.DocumentElement.AppendChild(copied);
                }
            }
            return resources;
        }

        #endregion
    }

    public static class Extensions
    {
        public static string ToSanitizedJs(this string @this)
        {
            var replacements = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("\\", "\\\\")
            };
            try
            {
                var sanitized = @this;
                foreach (var tuple in replacements)
                {
                    sanitized = sanitized.Replace(tuple.Item1, tuple.Item2);
                }
                return sanitized;
            }
            catch (Exception e)
            {
                log4net.LogManager.GetLogger("BaseViewPage").Error("JS string sanitization failed!", e);
                return @this;
            }
        }
    }
}