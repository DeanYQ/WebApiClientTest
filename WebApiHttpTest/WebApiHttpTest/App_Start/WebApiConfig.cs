using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiHttpTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.MapHttpAttributeRoutes();
        }
    }
}
