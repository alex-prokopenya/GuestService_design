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

    [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    public class GuestStrings
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
                string fileName = System.IO.Path.Combine(GuestService.Notifications.TemplateParser.GetAssemblyDirectory(), "Resources", "GuestStrings." + str + ".resx");

                if (System.IO.File.Exists(fileName))
                {
                    ResXResourceReader rr = new ResXResourceReader(fileName);

                    foreach (DictionaryEntry d in rr)
                        strings[str].Add(d.Key.ToString(), d.Value.ToString());
                }
            }

            if (strings[str].ContainsKey(key))
                return strings[str][key];

            return GuestStrings.ResourceManager.GetString(key, resourceCultureParam != null ? resourceCultureParam : GuestStrings.resourceCulture);
        }

        internal GuestStrings()
        {
        }

        public static string Authenticate_1
        {
            get
            {
                return Get("Authenticate_1", resourceCulture);
            }
        }

        public static string Authenticate_2
        {
            get
            {
                return Get("Authenticate_2", resourceCulture);
            }
        }

        public static string Authenticate_3
        {
            get
            {
                return Get("Authenticate_3", resourceCulture);
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

        public static string DepartureBack
        {
            get
            {
                return Get("DepartureBack", resourceCulture);
            }
        }

        public static string DepartureNotFound
        {
            get
            {
                return Get("DepartureNotFound", resourceCulture);
            }
        }

        public static string DepartureNotFoundNote_1
        {
            get
            {
                return Get("DepartureNotFoundNote_1", resourceCulture);
            }
        }

        public static string DepartureNotFoundNote_2
        {
            get
            {
                return Get("DepartureNotFoundNote_2", resourceCulture);
            }
        }

        public static string DepartureNoTransferFound
        {
            get
            {
                return Get("DepartureNoTransferFound", resourceCulture);
            }
        }

        public static string DepartureTitle
        {
            get
            {
                return Get("DepartureTitle", resourceCulture);
            }
        }

        public static string FindOrderChoose_1
        {
            get
            {
                return Get("FindOrderChoose_1", resourceCulture);
            }
        }

        public static string FindOrderChoose_2
        {
            get
            {
                return Get("FindOrderChoose_2", resourceCulture);
            }
        }

        public static string FindOrderClaim
        {
            get
            {
                return Get("FindOrderClaim", resourceCulture);
            }
        }

        public static string FindOrderDeleteButton
        {
            get
            {
                return Get("FindOrderDeleteButton", resourceCulture);
            }
        }

        public static string FindOrderFindButton
        {
            get
            {
                return Get("FindOrderFindButton", resourceCulture);
            }
        }

        public static string FindOrderFound
        {
            get
            {
                return Get("FindOrderFound", resourceCulture);
            }
        }

        public static string FindOrderKnow_1
        {
            get
            {
                return Get("FindOrderKnow_1", resourceCulture);
            }
        }

        public static string FindOrderKnow_2
        {
            get
            {
                return Get("FindOrderKnow_2", resourceCulture);
            }
        }

        public static string FindOrderLinkOrderButton
        {
            get
            {
                return Get("FindOrderLinkOrderButton", resourceCulture);
            }
        }

        public static string FindOrderModel_D_Claim
        {
            get
            {
                return Get("FindOrderModel_D_Claim", resourceCulture);
            }
        }

        public static string FindOrderModel_N_Claim
        {
            get
            {
                return Get("FindOrderModel_N_Claim", resourceCulture);
            }
        }

        public static string FindOrderModel_N_ClaimName
        {
            get
            {
                return Get("FindOrderModel_N_ClaimName", resourceCulture);
            }
        }

        public static string FindOrderModel_N_Passport
        {
            get
            {
                return Get("FindOrderModel_N_Passport", resourceCulture);
            }
        }

        public static string FindOrderModel_R_Claim
        {
            get
            {
                return Get("FindOrderModel_R_Claim", resourceCulture);
            }
        }

        public static string FindOrderModel_R_ClaimName
        {
            get
            {
                return Get("FindOrderModel_R_ClaimName", resourceCulture);
            }
        }

        public static string FindOrderModel_R_Passport
        {
            get
            {
                return Get("FindOrderModel_R_Passport", resourceCulture);
            }
        }

        public static string FindOrderName
        {
            get
            {
                return Get("FindOrderName", resourceCulture);
            }
        }

        public static string FindOrderNameSmall
        {
            get
            {
                return Get("FindOrderNameSmall", resourceCulture);
            }
        }

        public static string FindOrderNoLinkedOrders
        {
            get
            {
                return Get("FindOrderNoLinkedOrders", resourceCulture);
            }
        }

        public static string FindOrderNotFound
        {
            get
            {
                return Get("FindOrderNotFound", resourceCulture);
            }
        }

        public static string FindOrderOrderTitle
        {
            get
            {
                return Get("FindOrderOrderTitle", resourceCulture);
            }
        }

        public static string FindOrderPassSer
        {
            get
            {
                return Get("FindOrderPassSer", resourceCulture);
            }
        }

        public static string FindOrderTitle
        {
            get
            {
                return Get("FindOrderTitle", resourceCulture);
            }
        }

        public static string GuestServicesExcursionDepartureTitle
        {
            get
            {
                return Get("GuestServicesExcursionDepartureTitle", resourceCulture);
            }
        }

        public static string GuestServicesFindOrder_1
        {
            get
            {
                return Get("GuestServicesFindOrder_1", resourceCulture);
            }
        }

        public static string GuestServicesFindOrder_2
        {
            get
            {
                return Get("GuestServicesFindOrder_2", resourceCulture);
            }
        }

        public static string GuestServicesFindOrder_3
        {
            get
            {
                return Get("GuestServicesFindOrder_3", resourceCulture);
            }
        }

        public static string GuestServicesLink
        {
            get
            {
                return Get("GuestServicesLink", resourceCulture);
            }
        }

        public static string GuestServicesTitle
        {
            get
            {
                return Get("GuestServicesTitle", resourceCulture);
            }
        }

        public static string GuestServiceTitle
        {
            get
            {
                return Get("GuestServiceTitle", resourceCulture);
            }
        }

        public static string HotelAlt
        {
            get
            {
                return Get("HotelAlt", resourceCulture);
            }
        }

        public static string HotelDepartureNoInformation
        {
            get
            {
                return Get("HotelDepartureNoInformation", resourceCulture);
            }
        }

        public static string HotelDepartureTitle
        {
            get
            {
                return Get("HotelDepartureTitle", resourceCulture);
            }
        }

        public static string HotelNotFound
        {
            get
            {
                return Get("HotelNotFound", resourceCulture);
            }
        }

        public static string HotelNotFound_1
        {
            get
            {
                return Get("HotelNotFound_1", resourceCulture);
            }
        }

        public static string HotelNotFound_Link
        {
            get
            {
                return Get("HotelNotFound_Link", resourceCulture);
            }
        }

        public static string HotelTitle
        {
            get
            {
                return Get("HotelTitle", resourceCulture);
            }
        }

        public static string MenuBookingAlt
        {
            get
            {
                return Get("MenuBookingAlt", resourceCulture);
            }
        }

        public static string MenuBookingText
        {
            get
            {
                return Get("MenuBookingText", resourceCulture);
            }
        }

        public static string MenuBookingTitle
        {
            get
            {
                return Get("MenuBookingTitle", resourceCulture);
            }
        }

        public static string MenuDepartureAlt
        {
            get
            {
                return Get("MenuDepartureAlt", resourceCulture);
            }
        }

        public static string MenuDepartureText
        {
            get
            {
                return Get("MenuDepartureText", resourceCulture);
            }
        }

        public static string MenuDepartureTitle
        {
            get
            {
                return Get("MenuDepartureTitle", resourceCulture);
            }
        }

        public static string MenuExcursionAlt
        {
            get
            {
                return Get("MenuExcursionAlt", resourceCulture);
            }
        }

        public static string MenuExcursionText
        {
            get
            {
                return Get("MenuExcursionText", resourceCulture);
            }
        }

        public static string MenuExcursionTitle
        {
            get
            {
                return Get("MenuExcursionTitle", resourceCulture);
            }
        }

        public static string MenuInformationAlt
        {
            get
            {
                return Get("MenuInformationAlt", resourceCulture);
            }
        }

        public static string MenuInformationText
        {
            get
            {
                return Get("MenuInformationText", resourceCulture);
            }
        }

        public static string MenuInformationTitle
        {
            get
            {
                return Get("MenuInformationTitle", resourceCulture);
            }
        }

        public static string MenuOrdersAlt
        {
            get
            {
                return Get("MenuOrdersAlt", resourceCulture);
            }
        }

        public static string MenuOrdersText
        {
            get
            {
                return Get("MenuOrdersText", resourceCulture);
            }
        }

        public static string MenuOrdersTitle
        {
            get
            {
                return Get("MenuOrdersTitle", resourceCulture);
            }
        }

        public static string MoreOrderAlt
        {
            get
            {
                return Get("MoreOrderAlt", resourceCulture);
            }
        }

        public static string MoreOrdersFindButton
        {
            get
            {
                return Get("MoreOrdersFindButton", resourceCulture);
            }
        }

        public static string MoreOrdersInstruction
        {
            get
            {
                return Get("MoreOrdersInstruction", resourceCulture);
            }
        }

        public static string MoreOrdersListOrderAlt
        {
            get
            {
                return Get("MoreOrdersListOrderAlt", resourceCulture);
            }
        }

        public static string MoreOrderTitle
        {
            get
            {
                return Get("MoreOrderTitle", resourceCulture);
            }
        }

        public static string OrderDoPaymentButton
        {
            get
            {
                return Get("OrderDoPaymentButton", resourceCulture);
            }
        }

        public static string OrderInfoTitle
        {
            get
            {
                return Get("OrderInfoTitle", resourceCulture);
            }
        }

        public static string OrderToPay
        {
            get
            {
                return Get("OrderToPay", resourceCulture);
            }
        }

        public static string OrderTotal
        {
            get
            {
                return Get("OrderTotal", resourceCulture);
            }
        }

        public static string PrintOrderBuildVoucherButton
        {
            get
            {
                return Get("PrintOrderBuildVoucherButton", resourceCulture);
            }
        }

        public static string PrintOrderConfirmCaption
        {
            get
            {
                return Get("PrintOrderConfirmCaption", resourceCulture);
            }
        }

        public static string PrintOrderModel_Claim
        {
            get
            {
                return Get("PrintOrderModel_Claim", resourceCulture);
            }
        }

        public static string PrintOrderModel_D_Claim
        {
            get
            {
                return Get("PrintOrderModel_D_Claim", resourceCulture);
            }
        }

        public static string PrintOrderModel_N_Claim
        {
            get
            {
                return Get("PrintOrderModel_N_Claim", resourceCulture);
            }
        }

        public static string PrintOrderModel_N_Name
        {
            get
            {
                return Get("PrintOrderModel_N_Name", resourceCulture);
            }
        }

        public static string PrintOrderModel_Name_1
        {
            get
            {
                return Get("PrintOrderModel_Name_1", resourceCulture);
            }
        }

        public static string PrintOrderModel_Name_2
        {
            get
            {
                return Get("PrintOrderModel_Name_2", resourceCulture);
            }
        }

        public static string PrintOrderModel_R_Claim
        {
            get
            {
                return Get("PrintOrderModel_R_Claim", resourceCulture);
            }
        }

        public static string PrintOrderModel_R_Name
        {
            get
            {
                return Get("PrintOrderModel_R_Name", resourceCulture);
            }
        }

        public static string PrintOrderNotFound
        {
            get
            {
                return Get("PrintOrderNotFound", resourceCulture);
            }
        }

        public static string PrintOrderTitle
        {
            get
            {
                return Get("PrintOrderTitle", resourceCulture);
            }
        }

        public static string PrintVoucherButton
        {
            get
            {
                return Get("PrintVoucherButton", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("GuestService.Resources.GuestStrings", typeof(GuestStrings).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        public static string String1
        {
            get
            {
                return Get("String1", resourceCulture);
            }
        }

        public static string SummaryCheckAnother
        {
            get
            {
                return Get("SummaryCheckAnother", resourceCulture);
            }
        }

        public static string SummaryFindButton
        {
            get
            {
                return Get("SummaryFindButton", resourceCulture);
            }
        }

        public static string SummaryFindReservationTitle
        {
            get
            {
                return Get("SummaryFindReservationTitle", resourceCulture);
            }
        }

        public static string SummaryNameLabel
        {
            get
            {
                return Get("SummaryNameLabel", resourceCulture);
            }
        }

        public static string SummaryNameLabel_1
        {
            get
            {
                return Get("SummaryNameLabel_1", resourceCulture);
            }
        }

        public static string SummaryNotFound
        {
            get
            {
                return Get("SummaryNotFound", resourceCulture);
            }
        }

        public static string SummaryReservationLabel
        {
            get
            {
                return Get("SummaryReservationLabel", resourceCulture);
            }
        }
    }
}

