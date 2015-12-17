﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MagicScores2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{eventName}/{round}/{detailedMode}",
                defaults: new { controller="Magic", action = "Index", eventName = "BFZ", round=3, detailedMode=false }
                );

            routes.MapRoute(
                name: "Details",
                url: "{eventName}/{round}/{player1}/{player2}",
                defaults: new { controller = "Magic", action = "Details", eventName = "ORI", round = 3, player1wins = UrlParameter.Optional}
            );
        }
    }
}
