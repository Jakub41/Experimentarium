using System;
using System.Web.Http;

namespace WebServiceAPITut
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
        }

        internal static Action<HttpConfiguration> Register()
        {
            throw new NotImplementedException();
        }
    }
}
