using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using log4net;
using log4net.Config;

namespace EuTravel_2.Web
{
    internal class CustomViewEngine : RazorViewEngine
    {
        public CustomViewEngine()
        {
            var viewLocations =  new[]
            {
                "~/Views/{0}.cshtml"
            };
            PartialViewLocationFormats = viewLocations;
            ViewLocationFormats = viewLocations;
        }
    }

    public class Global : HttpApplication
    {
        public void Application_Start(object sender, EventArgs e)
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomViewEngine());
            XmlConfigurator.Configure();
            LogManager.GetLogger(GetType()).Info("Application start!");
          
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            if (!Session.IsNewSession) return;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
        }

        protected void Application_PostAuthorizeRequest()
        {
            if (HttpContext.Current.Request.Url.AbsolutePath.Contains("/FormAPIs/"))
            {
                HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Get the exception object.
            var exc = Server.GetLastError();
            // Log the exception and notify system operators
            LogManager.GetLogger(GetType()).Error($"Error in: {HttpContext.Current?.Request?.Url}", exc);
            // Clear the error from the server
            Server.ClearError();
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        public void Application_End(object sender, EventArgs e)
        {
            LogManager.GetLogger(GetType()).Info("Application end!");
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
        }
    }
}
