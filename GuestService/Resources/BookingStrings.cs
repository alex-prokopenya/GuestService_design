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
    public class BookingStrings
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
                string fileName = System.IO.Path.Combine(GuestService.Notifications.TemplateParser.GetAssemblyDirectory(), "Resources", "BookingStrings." + str + ".resx");

                if (System.IO.File.Exists(fileName))
                {
                    ResXResourceReader rr = new ResXResourceReader(fileName);

                    foreach (DictionaryEntry d in rr)
                        strings[str].Add(d.Key.ToString(), d.Value.ToString());
                }
            }

            if (strings[str].ContainsKey(key))
                return strings[str][key];
            
            var tmp = BookingStrings.ResourceManager.GetString(key, resourceCultureParam != null ? resourceCultureParam:BookingStrings.resourceCulture);

            if (tmp == null)
                return "not found " + key;
            else
                return tmp;
        }

        internal BookingStrings()
        {
        }

        public static string BookingAgreementCancel
        {
            get
            {
                return Get("BookingAgreementCancel", resourceCulture);
            }
        }

        public static string BookingAgreementConfirm
        {
            get
            {
                return Get("BookingAgreementConfirm", resourceCulture);
            }
        }

        public static string BookingAgreementConfirmMessage_1
        {
            get
            {
                return Get("BookingAgreementConfirmMessage_1", resourceCulture);
            }
        }

        public static string BookingAgreementConfirmMessage_2
        {
            get
            {
                return Get("BookingAgreementConfirmMessage_2", resourceCulture);
            }
        }

        public static string BookingAgreementTitle
        {
            get
            {
                return Get("BookingAgreementTitle", resourceCulture);
            }
        }

        public static string BookingErrorTitle
        {
            get
            {
                return Get("BookingErrorTitle", resourceCulture);
            }
        }

        public static string BookingFormAddress
        {
            get
            {
                return Get("BookingFormAddress", resourceCulture);
            }
        }

        public static string BookingFormMail
        {
            get
            {
                return Get("BookingFormMail", resourceCulture);
            }
        }

        public static string BookingFormName
        {
            get
            {
                return Get("BookingFormName", resourceCulture);
            }
        }

        public static string BookingFormNote
        {
            get
            {
                return Get("BookingFormNote", resourceCulture);
            }
        }

        public static string BookingFormPhone
        {
            get
            {
                return Get("BookingFormPhone", resourceCulture);
            }
        }

        public static string BookingInProcess
        {
            get
            {
                return Get("BookingInProcess", resourceCulture);
            }
        }

        public static string BookingMenuTitle
        {
            get
            {
                return Get("BookingMenuTitle", resourceCulture);
            }
        }

        public static string BookingModel_R_CustomerMobile
        {
            get
            {
                return Get("BookingModel_R_CustomerMobile", resourceCulture);
            }
        }
        public static string BookingModel_R_CustomerSecondNameReg
        {
            get
            {
                return Get("BookingModel_R_CustomerSecondNameReg");
            }
        }
        public static string BookingModel_R_CustomerNameReg
        {
            get
            {
                return Get("BookingModel_R_CustomerNameReg");
            }
        }


        public static string BookingModel_R_CustomerSecondName
        {
            get
            {
                return Get("BookingModel_R_CustomerSecondName");
            }
        }
        public static string BookingModel_R_CustomerName
        {
            get
            {
                return Get("BookingModel_R_CustomerName", resourceCulture);
            }
        }

        public static string BookingModel_R_UserEmail
        {
            get
            {
                return Get("BookingModel_R_UserEmail", resourceCulture);
            }
        }

        public static string BookingPayButton
        {
            get
            {
                return Get("BookingPayButton", resourceCulture);
            }
        }

        public static string BookingProcessing_OrderTitle_1
        {
            get
            {
                return Get("BookingProcessing_OrderTitle_1", resourceCulture);
            }
        }

        public static string BookingProcessing_OrderTitle_2
        {
            get
            {
                return Get("BookingProcessing_OrderTitle_2", resourceCulture);
            }
        }

        public static string BookingProcessing_Title
        {
            get
            {
                return Get("BookingProcessing_Title", resourceCulture);
            }
        }

        public static string BookingResultText_1
        {
            get
            {
                return Get("BookingResultText_1", resourceCulture);
            }
        }

        public static string BookingResultText_2
        {
            get
            {
                return Get("BookingResultText_2", resourceCulture);
            }
        }

        public static string BookingResultTitle
        {
            get
            {
                return Get("BookingResultTitle", resourceCulture);
            }
        }

        public static string BookingReturnToOrder
        {
            get
            {
                return Get("BookingReturnToOrder", resourceCulture);
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

        public static string EmptyCart_1
        {
            get
            {
                return Get("EmptyCart_1", resourceCulture);
            }
        }

        public static string EmptyCart_2
        {
            get
            {
                return Get("EmptyCart_2", resourceCulture);
            }
        }

        public static string ErrorMessageTitle
        {
            get
            {
                return Get("ErrorMessageTitle", resourceCulture);
            }
        }

        public static string GoBack
        {
            get
            {
                return Get("GoBack", resourceCulture);
            }
        }

        public static string GuestServiceTitle
        {
            get
            {
                return Get("GuestServiceTitle", resourceCulture);
            }
        }

        public static string OrderTotalLabel
        {
            get
            {
                return Get("OrderTotalLabel", resourceCulture);
            }
        }

        public static string Promo_ApplyCommand
        {
            get
            {
                return Get("Promo_ApplyCommand", resourceCulture);
            }
        }

        public static string Promo_ApplyLabel
        {
            get
            {
                return Get("Promo_ApplyLabel", resourceCulture);
            }
        }

        public static string Promo_FormButton
        {
            get
            {
                return Get("Promo_FormButton", resourceCulture);
            }
        }

        public static string Promo_FormLabel
        {
            get
            {
                return Get("Promo_FormLabel", resourceCulture);
            }
        }

        public static string Promo_FormTitle
        {
            get
            {
                return Get("Promo_FormTitle", resourceCulture);
            }
        }

        public static string RemoveOrderCancelButton
        {
            get
            {
                return Get("RemoveOrderCancelButton", resourceCulture);
            }
        }

        public static string RemoveOrderConfirmButton
        {
            get
            {
                return Get("RemoveOrderConfirmButton", resourceCulture);
            }
        }

        public static string RemoveOrderConfirmText
        {
            get
            {
                return Get("RemoveOrderConfirmText", resourceCulture);
            }
        }

        public static string RemoveOrderConfirmTitle
        {
            get
            {
                return Get("RemoveOrderConfirmTitle", resourceCulture);
            }
        }

        public static string RemoveOrderLink
        {
            get
            {
                return Get("RemoveOrderLink", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("GuestService.Resources.BookingStrings", typeof(BookingStrings).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        public static string RulesAccepted
        {
            get
            {
                return Get("RulesAccepted", resourceCulture);
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

