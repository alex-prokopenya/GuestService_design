namespace GuestService
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region string url = "error/{code}";

            string name = "error";
            string url = "error/{code}";
            object defaults = new {
                controller = "error",
                action = "index",
                code = UrlParameter.Optional
            };
            routes.MapRoute(name, url, defaults);
            #endregion

            #region  url = "{language}/countries/{country}";

            name = "countries";
            url = "{language}/countries/{country}";
            defaults = new
            {
                controller = "countries",
                action = "index",
                country = UrlParameter.Optional
            };
            routes.MapRoute(name, url, defaults);

            #endregion

            #region  url = "{language}/partners/{country}";

            name = "partners";
            url = "{language}/partners/{country}";
            defaults = new
            {
                controller = "partners",
                action = "index",
                country = UrlParameter.Optional
            };
            routes.MapRoute(name, url, defaults);

            #endregion

            #region  url = "{language}/info/{id}";
            name = "info";
            url = "{language}/info/{id}";
            defaults = new
            {
                controller = "info",
                action = "index",
                id = UrlParameter.Optional
            };
            routes.MapRoute(name, url, defaults);
            #endregion

            #region url = "{language}/excursion/addcart/{id}";

            name = "excursionscart";
            url = "{language}/excursion/addcart/{id}";
            defaults = new
            {
                controller = "excursion",
                action = "addcart",
                id = UrlParameter.Optional
            };

            object constraints = new
            {
                language = @"\w\w(\-\w\w)?"
            };

            routes.MapRoute(name, url, defaults, constraints);
            #endregion

            #region url = "{language}/excursion/addrating/{ id}";
            name = "excursionsrating";
            url = "{language}/excursion/addrating/{id}";
            defaults = new
            {
                controller = "excursion",
                action = "addrating",
                id = UrlParameter.Optional
            };

            routes.MapRoute(name, url, defaults, constraints);
            #endregion

            #region url = "{language}/excursion/{region}";

            name = "excursions";
            url = "{language}/excursion/{region}";
            defaults = new
            {
                controller = "excursion",
                action = "index",
                region = UrlParameter.Optional
            };
            
            routes.MapRoute(name, url, defaults, constraints);

            #endregion

            #region url = "{language}/{controller}/{action}/{id}";

            name = "language";
            url = "{language}/{controller}/{action}/{id}";
            defaults = new {
                   controller = "excursion",
                   action = "index",
                   id = UrlParameter.Optional
            };

            routes.MapRoute(name, url, defaults, constraints);

            #endregion

            #region  url = "{controller}/{action}/{id}";

            name = "default";
            url = "{controller}/{action}/{id}";
            defaults = new {
                controller = "excursion",
                action = "index",
                id = UrlParameter.Optional
            };
            routes.MapRoute(name, url, defaults);

            #endregion
        }
    }
}

