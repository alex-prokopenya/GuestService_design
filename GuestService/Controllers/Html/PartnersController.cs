using GuestService.Models;

namespace GuestService.Controllers.Html
{
    using GuestService.Data;
    using Sm.System.Mvc;
    using Sm.System.Mvc.Language;
    using System;
    using System.Web.Mvc;
    using System.Collections.Generic;
    using Sm.System.Database;
    using System.Data;
    using GuestService;
    using GuestService.Code;
    using GuestService.Models.Countries;

    [HttpPreferences, WebSecurityInitializer, UrlLanguage]
    public class PartnersController : BaseController
    {
        public enum PartnerType
        {
            All, //все партнеры
            Provider, //провайдеры
            Agent //отели и агентства
        }

        //список партнеров, по стране
        public KeyValuePair<string, string>[] GetCountryPartners(int countryID, PartnerType type)
        {

            var selectQuery = "select p.inc, p.name, p.lname  from guestservice_UserProfile as us, partner as p where ";
 
            if (type == PartnerType.Provider)
                selectQuery += "us.providerId = p.inc ";
            else if (type == PartnerType.Agent)
                selectQuery += "us.partnerId = p.inc ";
            else
                selectQuery += "us.partnerId = p.inc or us.providerId = p.inc ";

            //фильтруем страну
            selectQuery += String.Format(" and p.town in (select inc from town where state in (select inc from state where inc = {0}))", countryID);

            //текущий язык
            DataSet set = DatabaseOperationProvider.Query(selectQuery, "partners", new { });


            var partners = new List<KeyValuePair<string, string>>();

            foreach (DataRow row in set.Tables["partners"].Rows)
            {
                var regionslug = StringsHelper.GenerateSlug(row["inc"].ToString());

                if (UrlLanguage.CurrentLanguage == "ru")
                    partners.Add(new KeyValuePair<string, string>(regionslug, row["name"].ToString()));
                else
                    partners.Add(new KeyValuePair<string, string>(regionslug, row["lname"].ToString()));
            }

            return partners.ToArray();
        }

        //список партнеров 
        public KeyValuePair<string, string>[] GetPartnersSearch(string searchText)
        {

            var selectQuery = String.Format(@"select p.inc, p.name, p.lname, s.name as 'sname', s.lname as 'slname'  
                                            from guestservice_UserProfile as us 
                                                inner join partner as p on us.partnerId = p.inc or us.providerId = p.inc
                                                inner join town as t on p.town = t.inc 
                                                inner join state as s on t.state = s.inc
                                            where p.lname like @text", searchText);

            //текущий язык
            DataSet set = DatabaseOperationProvider.Query(selectQuery, "partners", new {text = string.Format("%{0}%", searchText) });


            var partners = new List<KeyValuePair<string, string>>();

            foreach (DataRow row in set.Tables["partners"].Rows)
            {
                var regionslug = StringsHelper.GenerateSlug(row["inc"].ToString());

                if (UrlLanguage.CurrentLanguage == "ru")
                    partners.Add(new KeyValuePair<string, string>(regionslug, row["name"] + "(" + row["sname"] + ")"));
                else
                    partners.Add(new KeyValuePair<string, string>(regionslug, row["lname"] + "(" + row["slname"] + ")"));
            }

            return partners.ToArray();
        }

        //список стран, в которых есть партнеры
        private static KeyValuePair<string, string>[] GetCountriesList()
        {
            var selectQuery = "select name, lname, inc from state where inc in (select state from town where inc in (select town from partner))";

            //текущий язык
            DataSet set = DatabaseOperationProvider.Query(selectQuery, "regions", new { });

            var countries = new List<KeyValuePair<string, string>>();

            foreach (DataRow row in set.Tables["regions"].Rows)
            {
                var slug = StringsHelper.GenerateSlug(row["lname"].ToString());

                if (slug == "") continue;

                if (UrlLanguage.CurrentLanguage == "ru")
                    countries.Add(new KeyValuePair<string, string>(slug, row["name"].ToString()));
                else
                    countries.Add(new KeyValuePair<string, string>(slug, row["lname"].ToString()));
            }

            return countries.ToArray();
        }

        //по слагу определяем страну (в которых есть партнер)
        private static int? GetCountryBySlug(string slug)
        {
            var selectQuery = "select name, lname, inc from state where inc in (select state from town where inc in (select town from partner))";

            //текущий язык
            DataSet set = DatabaseOperationProvider.Query(selectQuery, "regions", new { });

            var countries = new List<KeyValuePair<string, string>>();

            foreach (DataRow row in set.Tables["regions"].Rows)
            {
                var dbslug = StringsHelper.GenerateSlug(row["lname"].ToString());

                if (dbslug == slug)
                    return row.ReadInt("inc");
            }

            return null;
        }

        [HttpPost, ActionName("index")]
        public ActionResult Search(string name)
        {
            if (name != "")
            {
                var model = new CountriesCatalog()
                {
                    Countries = GetPartnersSearch(name),
                    Description = "Список найденных партнеров проекта ExGo",
                    Title = "Найденные партнеры",
                    Keywords = "Каталог, купить экскурсию",
                    SeoText =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                };

                return base.View(model);
            }
            else
            {
                return Index(null);
            }
        }

        //список стран
        [HttpGet, ActionName("index")]
        public ActionResult Index(string country)
        {
            //ищем список стран, в которых есть экскурсии
            if (string.IsNullOrEmpty(country))
            {
                var model = new CountriesCatalog()
                {
                    Countries = GetCountriesList(),
                    Description = "Каталог стран партнеров проекта ExGo",
                    Title = "Каталог стран партнеров",
                    Keywords = "Каталог, купить экскурсию",
                    SeoText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                };

                return base.View(model);
            }
            else
            {
                var lang = UrlLanguage.CurrentLanguage;
                var countryId = GetCountryBySlug(country);

                if (countryId.HasValue)
                {
                    var seoFields = SeoObjectProvider.GetSeoObject(countryId.Value, "country", lang);

                    var model = new CountryPartners()
                    {
                        CountryName = country,
                        CountryId = country,
                        Description = seoFields.Description,
                        Title = seoFields.Title,
                        Keywords = seoFields.Keywords,
                        SeoText = seoFields.SeoText,
                        Providers = GetCountryPartners(countryId.Value, PartnerType.Provider),
                        Agents = GetCountryPartners(countryId.Value, PartnerType.Agent)
                    };

                    return base.View("country", model);
                }
                else
                    return RedirectPermanent("/error/404");
            }
        }
    }
}