﻿
using System.Web.Http;

namespace JamesWoods.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes(); 
        }
    }
}
