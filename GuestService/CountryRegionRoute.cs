using System;
using System.Web;
using System.Web.Routing;
using Sm.System.Database;
using System.Collections.Generic;

namespace GuestService{
    public class CountryRegionRoute : IRouteConstraint
    {
        private List<string> countries = new List<string>();

        public CountryRegionRoute()
        {
            var countriesList = GuestService.Controllers.Html.CountriesController.GetCountriesList();

            foreach (var item in countriesList)
                countries.Add(item.Key);
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return countries.Contains(values[parameterName].ToString().ToLower());
        }
    }
}