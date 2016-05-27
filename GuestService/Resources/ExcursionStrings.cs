namespace GuestService.Resources
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    using Sm.System.Mvc.Language;
    using System.Collections.Generic;
    using System.Collections;

    [DebuggerNonUserCode, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), CompilerGenerated]
    public class ExcursionStrings
    {
        private static CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        private static Dictionary<string, Dictionary<string, string>> strings = new Dictionary<string, Dictionary<string, string>>();

        public static string Get(string key, CultureInfo resourceCultureParam = null)
        {
            var str = UrlLanguage.CurrentLanguage;

            if (!strings.ContainsKey(str))
            {
                strings[str] = new Dictionary<string, string>();

                //загрузить строки из xml
                string fileName = System.IO.Path.Combine(GuestService.Notifications.TemplateParser.GetAssemblyDirectory(), "Resources", "ExcursionStrings." + str + ".resx");

                if (System.IO.File.Exists(fileName))
                {
                    ResXResourceReader rr = new ResXResourceReader(fileName);

                    foreach (DictionaryEntry d in rr)
                        strings[str].Add(d.Key.ToString(), d.Value.ToString());
                }
            }

            if (strings[str].ContainsKey(key))
                return strings[str][key];

            return ExcursionStrings.ResourceManager.GetString(key, resourceCultureParam != null ? resourceCultureParam : ExcursionStrings.resourceCulture);
        }

        internal ExcursionStrings()
        {
        }

        public static string AddReviewLink
        {
            get
            {
                return Get("AddReviewLink", resourceCulture);
            }
        }

        public static string AddReviewNo
        {
            get
            {
                return Get("AddReviewNo", resourceCulture);
            }
        }

        public static string AddReviewText
        {
            get
            {
                return Get("AddReviewText", resourceCulture);
            }
        }

        public static string AddReviewTitle
        {
            get
            {
                return Get("AddReviewTitle", resourceCulture);
            }
        }

        public static string AddReviewYes
        {
            get
            {
                return Get("AddReviewYes", resourceCulture);
            }
        }

        public static string BookButton
        {
            get
            {
                return Get("BookButton", resourceCulture);
            }
        }

        public static string BookNowButton
        {
            get
            {
                return Get("BookNowButton", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        public static string DateTimeFormat
        {
            get
            {
                return Get("DateTimeFormat", resourceCulture);
            }
        }

        public static string DateTimeLanguage
        {
            get
            {
                return Get("DateTimeLanguage", resourceCulture);
            }
        }

        public static string DeatilGroupSize
        {
            get
            {
                return Get("DeatilGroupSize", resourceCulture);
            }
        }

        public static string DepartureLabel
        {
            get
            {
                return Get("DepartureLabel", resourceCulture);
            }
        }

        public static string DescriptionInfo_Categories
        {
            get
            {
                return Get("DescriptionInfo_Categories", resourceCulture);
            }
        }

        public static string DescriptionInfo_Direction
        {
            get
            {
                return Get("DescriptionInfo_Direction", resourceCulture);
            }
        }

        public static string DescriptionInfo_Duration
        {
            get
            {
                return Get("DescriptionInfo_Duration", resourceCulture);
            }
        }

        public static string DescriptionInfo_Language
        {
            get
            {
                return Get("DescriptionInfo_Language", resourceCulture);
            }
        }

        public static string DescriptionInfo_Partner
        {
            get
            {
                return Get("DescriptionInfo_Partner", resourceCulture);
            }
        }

        public static string DetailAdult
        {
            get
            {
                return Get("DetailAdult", resourceCulture);
            }
        }

        public static string DetailChild
        {
            get
            {
                return Get("DetailChild", resourceCulture);
            }
        }

        public static string DetailDateTitle
        {
            get
            {
                return Get("DetailDateTitle", resourceCulture);
            }
        }

        public static string DetailDeparture
        {
            get
            {
                return Get("DetailDeparture", resourceCulture);
            }
        }

        public static string DetailDescription
        {
            get
            {
                return Get("DetailDescription", resourceCulture);
            }
        }

        public static string DetailExcursionDateTitle
        {
            get
            {
                return Get("DetailExcursionDateTitle", resourceCulture);
            }
        }

        public static string DetailInfant
        {
            get
            {
                return Get("DetailInfant", resourceCulture);
            }
        }

        public static string DetailMapExpand
        {
            get
            {
                return Get("DetailMapExpand", resourceCulture);
            }
        }

        public static string DetailOnsaleTill
        {
            get
            {
                return Get("DetailOnsaleTill", resourceCulture);
            }
        }

        public static string DetailPrice
        {
            get
            {
                return Get("DetailPrice", resourceCulture);
            }
        }

        public static string DetailPriceTitle
        {
            get
            {
                return Get("DetailPriceTitle", resourceCulture);
            }
        }

        public static string DetailReturnToExcursionDate
        {
            get
            {
                return Get("DetailReturnToExcursionDate", resourceCulture);
            }
        }

        public static string DetailReturnToExcursionList
        {
            get
            {
                return Get("DetailReturnToExcursionList", resourceCulture);
            }
        }

        public static string DetailSelectedDateTitle
        {
            get
            {
                return Get("DetailSelectedDateTitle", resourceCulture);
            }
        }

        public static string DetailServicePrice
        {
            get
            {
                return Get("DetailServicePrice", resourceCulture);
            }
        }

        public static string DurationAlt
        {
            get
            {
                return Get("DurationAlt", resourceCulture);
            }
        }

        public static string DurationDay
        {
            get
            {
                return Get("DurationDay", resourceCulture);
            }
        }

        public static string DurationDays
        {
            get
            {
                return Get("DurationDays", resourceCulture);
            }
        }

        public static string DurationHour
        {
            get
            {
                return Get("DurationHour", resourceCulture);
            }
        }

        public static string DurationHours
        {
            get
            {
                return Get("DurationHours", resourceCulture);
            }
        }

        public static string DurationMin
        {
            get
            {
                return Get("DurationMin", resourceCulture);
            }
        }

        public static string DurationMins
        {
            get
            {
                return Get("DurationMins", resourceCulture);
            }
        }

        public static string ErrorGuestCount
        {
            get
            {
                return Get("ErrorGuestCount", resourceCulture);
            }
        }

        public static string ErrorInvalidParams
        {
            get
            {
                return Get("ErrorInvalidParams", resourceCulture);
            }
        }

        public static string ErrorSummary
        {
            get
            {
                return Get("ErrorSummary", resourceCulture);
            }
        }

        public static string ExcursionLanguage
        {
            get
            {
                return Get("ExcursionLanguage", resourceCulture);
            }
        }

        public static string ExcursionMapMarkerDeparture
        {
            get
            {
                return Get("ExcursionMapMarkerDeparture", resourceCulture);
            }
        }

        public static string ExcursionMapMarkerLocation
        {
            get
            {
                return Get("ExcursionMapMarkerLocation", resourceCulture);
            }
        }

        public static string ExcursionNotFound
        {
            get
            {
                return Get("ExcursionNotFound", resourceCulture);
            }
        }

        public static string ExcursionRegionTitle
        {
            get
            {
                return Get("ExcursionRegionTitle", resourceCulture);
            }
        }

        public static string ExcursionReviewCountTitle
        {
            get
            {
                return Get("ExcursionReviewCountTitle", resourceCulture);
            }
        }

        public static string ExcursionReviewNote1
        {
            get
            {
                return Get("ExcursionReviewNote1", resourceCulture);
            }
        }

        public static string ExcursionReviewNote2
        {
            get
            {
                return Get("ExcursionReviewNote2", resourceCulture);
            }
        }

        public static string ExcursionReviewTitle
        {
            get
            {
                return Get("ExcursionReviewTitle", resourceCulture);
            }
        }

        public static string ExcursionTitle
        {
            get
            {
                return Get("ExcursionTitle", resourceCulture);
            }
        }

        public static string ExtraFilters
        {
            get
            {
                return Get("ExtraFilters", resourceCulture);
            }
        }

        public static string ExtraFiltersAllDates
        {
            get
            {
                return Get("ExtraFiltersAllDates", resourceCulture);
            }
        }

        public static string ExtraFiltersCategory
        {
            get
            {
                return Get("ExtraFiltersCategory", resourceCulture);
            }
        }

        public static string ExtraFiltersDate
        {
            get
            {
                return Get("ExtraFiltersDate", resourceCulture);
            }
        }

        public static string ExtraFiltersDepartures
        {
            get
            {
                return Get("ExtraFiltersDepartures", resourceCulture);
            }
        }

        public static string ExtraFiltersDirection
        {
            get
            {
                return Get("ExtraFiltersDirection", resourceCulture);
            }
        }

        public static string ExtraFiltersLanguage
        {
            get
            {
                return Get("ExtraFiltersLanguage", resourceCulture);
            }
        }

        public static string FreeSeatsLabel
        {
            get
            {
                return Get("FreeSeatsLabel", resourceCulture);
            }
        }

        public static string GeorgaphyTitle
        {
            get
            {
                return Get("GeorgaphyTitle", resourceCulture);
            }
        }

        public static string GuestServiceTitle
        {
            get
            {
                return Get("GuestServiceTitle", resourceCulture);
            }
        }

        public static string HelpPlease
        {
            get
            {
                return Get("HelpPlease", resourceCulture);
            }
        }

        public static string MapHideLink
        {
            get
            {
                return Get("MapHideLink", resourceCulture);
            }
        }

        public static string MapShowLink
        {
            get
            {
                return Get("MapShowLink", resourceCulture);
            }
        }

        public static string NavigateCategory
        {
            get
            {
                return Get("NavigateCategory", resourceCulture);
            }
        }

        public static string NavigateExcursions
        {
            get
            {
                return Get("NavigateExcursions", resourceCulture);
            }
        }

        public static string OrderAddShopCartButton
        {
            get
            {
                return Get("OrderAddShopCartButton", resourceCulture);
            }
        }

        public static string OrderAddShopCartSuccess
        {
            get
            {
                return Get("OrderAddShopCartSuccess", resourceCulture);
            }
        }

        public static string OrderAdult
        {
            get
            {
                return Get("OrderAdult", resourceCulture);
            }
        }

        public static string OrderChild
        {
            get
            {
                return Get("OrderChild", resourceCulture);
            }
        }

        public static string OrderCloseButton
        {
            get
            {
                return Get("OrderCloseButton", resourceCulture);
            }
        }

        public static string OrderCount
        {
            get
            {
                return Get("OrderCount", resourceCulture);
            }
        }

        public static string OrderFormHelp
        {
            get
            {
                return Get("OrderFormHelp", resourceCulture);
            }
        }

        public static string OrderGoShoppingCart
        {
            get
            {
                return Get("OrderGoShoppingCart", resourceCulture);
            }
        }

        public static string OrderInfant
        {
            get
            {
                return Get("OrderInfant", resourceCulture);
            }
        }

        public static string OrderName
        {
            get
            {
                return Get("OrderName", resourceCulture);
            }
        }

        public static string OrderNote
        {
            get
            {
                return Get("OrderNote", resourceCulture);
            }
        }

        public static string OrderPhone
        {
            get
            {
                return Get("OrderPhone", resourceCulture);
            }
        }

        public static string OrderPickUp
        {
            get
            {
                return Get("OrderPickUp", resourceCulture);
            }
        }

        public static string OrderPickupHotel
        {
            get
            {
                return Get("OrderPickupHotel", resourceCulture);
            }
        }

        public static string OrderPriceForPax
        {
            get
            {
                return Get("OrderPriceForPax", resourceCulture);
            }
        }

        public static string OrderPriceForService
        {
            get
            {
                return Get("OrderPriceForService", resourceCulture);
            }
        }

        public static string OrderReturnExcursionList
        {
            get
            {
                return Get("OrderReturnExcursionList", resourceCulture);
            }
        }

        public static string OrderTitle
        {
            get
            {
                return Get("OrderTitle", resourceCulture);
            }
        }

        public static string PartnerAlt
        {
            get
            {
                return Get("PartnerAlt", resourceCulture);
            }
        }

        public static string PickupHotelHint
        {
            get
            {
                return Get("PickupHotelHint", resourceCulture);
            }
        }

        public static string PriceByPax
        {
            get
            {
                return Get("PriceByPax", resourceCulture);
            }
        }

        public static string PriceByService
        {
            get
            {
                return Get("PriceByService", resourceCulture);
            }
        }

        public static string PriceFrom
        {
            get
            {
                return Get("PriceFrom", resourceCulture);
            }
        }

        public static string PriceNotFound
        {
            get
            {
                return Get("PriceNotFound", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("GuestService.Resources.ExcursionStrings", typeof(ExcursionStrings).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        public static string ReviewHintNegative
        {
            get
            {
                return Get("ReviewHintNegative", resourceCulture);
            }
        }

        public static string ReviewHintPositive
        {
            get
            {
                return Get("ReviewHintPositive", resourceCulture);
            }
        }

        public static string ReviewNoRanking
        {
            get
            {
                return Get("ReviewNoRanking", resourceCulture);
            }
        }

        public static string ReviewTitle
        {
            get
            {
                return Get("ReviewTitle", resourceCulture);
            }
        }

        public static string SearchDeparture_AnyPoint
        {
            get
            {
                return Get("SearchDeparture_AnyPoint", resourceCulture);
            }
        }

        public static string SearchPlaceholder
        {
            get
            {
                return Get("SearchPlaceholder", resourceCulture);
            }
        }

        public static string SearchTitle
        {
            get
            {
                return Get("SearchTitle", resourceCulture);
            }
        }

        public static string ShowMap
        {
            get
            {
                return Get("ShowMap", resourceCulture);
            }
        }

        public static string SortOrderByName
        {
            get
            {
                return Get("SortOrderByName", resourceCulture);
            }
        }

        public static string SortOrderByPrice
        {
            get
            {
                return Get("SortOrderByPrice", resourceCulture);
            }
        }

        public static string Title
        {
            get
            {
                return Get("Title", resourceCulture);
            }
        }
    }
}

