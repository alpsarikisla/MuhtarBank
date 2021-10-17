﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MuhtarBank
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "SecondApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "MusteriKontrol",
               routeTemplate: "api/{controller}/{action}/{musteriKodu}/{sifre}",
               defaults: new { id = RouteParameter.Optional }
           );
        }
    }
}
