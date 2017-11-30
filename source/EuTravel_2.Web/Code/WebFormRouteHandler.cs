using System;
using System.Web;
using System.Web.Routing;
using System.Web.Compilation;

/// <summary>
/// Summary description for WebRouteHandler
/// </summary>
public class WebFormRouteHandler<T> : IRouteHandler where T : IHttpHandler, new()
{
    public string VirtualPath { get; set; }

    public WebFormRouteHandler(string virtualPath)
    {
        this.VirtualPath = virtualPath;
    }

    #region IRouteHandler Members

    public IHttpHandler GetHttpHandler(RequestContext requestContext)
    {
	    var pagePath = (VirtualPath != null && VirtualPath.Contains("?"))
		                   ? VirtualPath.Substring(0, VirtualPath.IndexOf('?'))
						   : VirtualPath;

        var instance = (pagePath != null)
                           ? (IHttpHandler)BuildManager.CreateInstanceFromVirtualPath(pagePath, typeof(T))
                           : new T();

	    if (VirtualPath != null && VirtualPath.Contains("?")) {
		    var querystring = VirtualPath.Substring(VirtualPath.IndexOf('?') + 1);
		    var parts = querystring.Split(new []{'&'}, StringSplitOptions.RemoveEmptyEntries);
		    foreach (var part in parts) {
				var keyVal = part.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
				if(keyVal.Length ==0) continue;
			    var key = keyVal[0];
			    var val = keyVal.Length > 1 ? keyVal[1] : string.Empty;
				requestContext.RouteData.Values.Add(key, val);
		    }
	    }

	    if (requestContext.RouteData.Values.Count > 0)
        {
            foreach(var val in requestContext.RouteData.Values)
            {
                HttpContext.Current.Items.Add(val.Key, val.Value.ToString());
            }
        }

        return instance;
    }

    #endregion
}

/// <summary>
/// Simple UrlRoutingHandler implementation
/// </summary>
public class RoutingHandler : UrlRoutingHandler
{
    protected override void VerifyAndProcessRequest(IHttpHandler httpHandler, HttpContextBase httpContext)
    {
    }
}
