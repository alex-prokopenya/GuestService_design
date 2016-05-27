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

    [CompilerGenerated, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode]
    public class AccountStrings
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
                string fileName = System.IO.Path.Combine(GuestService.Notifications.TemplateParser.GetAssemblyDirectory(), "Resources", "AccountStrings." + str + ".resx");

                if (System.IO.File.Exists(fileName))
                {
                    ResXResourceReader rr = new ResXResourceReader(fileName);

                    foreach (DictionaryEntry d in rr)
                        strings[str].Add(d.Key.ToString(), d.Value.ToString());
                }
            }

            if (strings[str].ContainsKey(key))
                return strings[str][key];

            return AccountStrings.ResourceManager.GetString(key, resourceCultureParam !=null? resourceCultureParam : AccountStrings.resourceCulture);
        }

        internal AccountStrings()
        {
        }

        public static string AccountLogin_EmailNotConfirmed
        {
            get
            {
                return Get("AccountLogin_EmailNotConfirmed", resourceCulture);
            }
        }

        public static string AccountLogin_InvalidCredentails
        {
            get
            {
                return Get("AccountLogin_InvalidCredentails", resourceCulture);
            }
        }

        public static string AccountRecovery_CannotRecovery
        {
            get
            {
                return Get("AccountRecovery_CannotRecovery", resourceCulture);
            }
        }

        public static string AccountResetPassword_CannotReset
        {
            get
            {
                return Get("AccountResetPassword_CannotReset", resourceCulture);
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

        public static string ErrorDuplicateEmail
        {
            get
            {
                return Get("ErrorDuplicateEmail", resourceCulture);
            }
        }

        public static string ErrorDuplicateUserName
        {
            get
            {
                return Get("ErrorDuplicateUserName", resourceCulture);
            }
        }

        public static string ErrorInvalidAnswer
        {
            get
            {
                return Get("ErrorInvalidAnswer", resourceCulture);
            }
        }

        public static string ErrorInvalidEmail
        {
            get
            {
                return Get("ErrorInvalidEmail", resourceCulture);
            }
        }

        public static string ErrorInvalidPassword
        {
            get
            {
                return Get("ErrorInvalidPassword", resourceCulture);
            }
        }

        public static string ErrorInvalidQuestion
        {
            get
            {
                return Get("ErrorInvalidQuestion", resourceCulture);
            }
        }

        public static string ErrorInvalidUserName
        {
            get
            {
                return Get("ErrorInvalidUserName", resourceCulture);
            }
        }

        public static string ErrorProviderError
        {
            get
            {
                return Get("ErrorProviderError", resourceCulture);
            }
        }

        public static string ErrorUnknownError
        {
            get
            {
                return Get("ErrorUnknownError", resourceCulture);
            }
        }

        public static string ErrorUserRejected
        {
            get
            {
                return Get("ErrorUserRejected", resourceCulture);
            }
        }

        public static string LocalPasswordModel_C_ConfirmPassword
        {
            get
            {
                return Get("LocalPasswordModel_C_ConfirmPassword", resourceCulture);
            }
        }

        public static string LocalPasswordModel_L_Password
        {
            get
            {
                return Get("LocalPasswordModel_L_Password", resourceCulture);
            }
        }

        public static string Login_AlreadyUser
        {
            get
            {
                return Get("Login_AlreadyUser", resourceCulture);
            }
        }

        public static string Login_Email
        {
            get
            {
                return Get("Login_Email", resourceCulture);
            }
        }

        public static string Login_Forget_1
        {
            get
            {
                return Get("Login_Forget_1", resourceCulture);
            }
        }

        public static string Login_Forget_2
        {
            get
            {
                return Get("Login_Forget_2", resourceCulture);
            }
        }

        public static string Login_LoginButton
        {
            get
            {
                return Get("Login_LoginButton", resourceCulture);
            }
        }

        public static string Login_LogoutButton
        {
            get
            {
                return Get("Login_LogoutButton", resourceCulture);
            }
        }

        public static string Login_Password
        {
            get
            {
                return Get("Login_Password", resourceCulture);
            }
        }

        public static string Login_Ph_Email
        {
            get
            {
                return Get("Login_Ph_Email", resourceCulture);
            }
        }

        public static string Login_Ph_Password
        {
            get
            {
                return Get("Login_Ph_Password", resourceCulture);
            }
        }

        public static string Login_RememberMe
        {
            get
            {
                return Get("Login_RememberMe", resourceCulture);
            }
        }

        public static string Login_Social
        {
            get
            {
                return Get("Login_Social", resourceCulture);
            }
        }

        public static string LoginModel_C_ConfirmPassword
        {
            get
            {
                return Get("LoginModel_C_ConfirmPassword", resourceCulture);
            }
        }

        public static string LoginModel_L_Password
        {
            get
            {
                return Get("LoginModel_L_Password", resourceCulture);
            }
        }

        public static string LoginModel_R_Mail
        {
            get
            {
                return Get("LoginModel_R_Mail", resourceCulture);
            }
        }

        public static string LoginModel_R_Password
        {
            get
            {
                return Get("LoginModel_R_Password", resourceCulture);
            }
        }

        public static string LoginModel_R_UserName
        {
            get
            {
                return Get("LoginModel_R_UserName", resourceCulture);
            }
        }

        public static string LoginText_1
        {
            get
            {
                return Get("LoginText_1", resourceCulture);
            }
        }

        public static string LoginText_2
        {
            get
            {
                return Get("LoginText_2", resourceCulture);
            }
        }

        public static string LoginTitle
        {
            get
            {
                return Get("LoginTitle", resourceCulture);
            }
        }

        public static string RecoveryModel_R_UserName
        {
            get
            {
                return Get("RecoveryModel_R_UserName", resourceCulture);
            }
        }

        public static string Register_As_1
        {
            get
            {
                return Get("Register_As_1", resourceCulture);
            }
        }

        public static string Register_As_2
        {
            get
            {
                return Get("Register_As_2", resourceCulture);
            }
        }

        public static string Register_Back
        {
            get
            {
                return Get("Register_Back", resourceCulture);
            }
        }

        public static string Register_ChangePassword
        {
            get
            {
                return Get("Register_ChangePassword", resourceCulture);
            }
        }

        public static string Register_ConfirmEmail
        {
            get
            {
                return Get("Register_ConfirmEmail", resourceCulture);
            }
        }

        public static string Register_ConfirmPassword
        {
            get
            {
                return Get("Register_ConfirmPassword", resourceCulture);
            }
        }

        public static string Register_Email
        {
            get
            {
                return Get("Register_Email", resourceCulture);
            }
        }

        public static string Register_EmailSuccess
        {
            get
            {
                return Get("Register_EmailSuccess", resourceCulture);
            }
        }

        public static string Register_EmailUnsuccess
        {
            get
            {
                return Get("Register_EmailUnsuccess", resourceCulture);
            }
        }

        public static string Register_ErrorSocial
        {
            get
            {
                return Get("Register_ErrorSocial", resourceCulture);
            }
        }

        public static string Register_ErrorSocialS
        {
            get
            {
                return Get("Register_ErrorSocialS", resourceCulture);
            }
        }

        public static string Register_MainFormLink
        {
            get
            {
                return Get("Register_MainFormLink", resourceCulture);
            }
        }

        public static string Register_Password
        {
            get
            {
                return Get("Register_Password", resourceCulture);
            }
        }

        public static string Register_Ph_ConfirmPassword
        {
            get
            {
                return Get("Register_Ph_ConfirmPassword", resourceCulture);
            }
        }

        public static string Register_Ph_Email
        {
            get
            {
                return Get("Register_Ph_Email", resourceCulture);
            }
        }

        public static string Register_Ph_Password
        {
            get
            {
                return Get("Register_Ph_Password", resourceCulture);
            }
        }

        public static string Register_RegisterButton
        {
            get
            {
                return Get("Register_RegisterButton", resourceCulture);
            }
        }

        public static string Register_ToMyAccount
        {
            get
            {
                return Get("Register_ToMyAccount", resourceCulture);
            }
        }

        public static string RegisterEmailNotConfirmed
        {
            get
            {
                return Get("RegisterEmailNotConfirmed", resourceCulture);
            }
        }

        public static string RegisterEmailNotConfirmedNote
        {
            get
            {
                return Get("RegisterEmailNotConfirmedNote", resourceCulture);
            }
        }

        public static string RegisterEmailNote
        {
            get
            {
                return Get("RegisterEmailNote", resourceCulture);
            }
        }

        public static string RegisterText
        {
            get
            {
                return Get("RegisterText", resourceCulture);
            }
        }

        public static string RegisterTitle
        {
            get
            {
                return Get("RegisterTitle", resourceCulture);
            }
        }

        public static string ResetPassword_CannotReset
        {
            get
            {
                return Get("ResetPassword_CannotReset", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("GuestService.Resources.AccountStrings", typeof(AccountStrings).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        public static string Restore_Btn
        {
            get
            {
                return Get("Restore_Btn", resourceCulture);
            }
        }

        public static string Restore_ConfirmPassword
        {
            get
            {
                return Get("Restore_ConfirmPassword", resourceCulture);
            }
        }

        public static string Restore_Email_Register
        {
            get
            {
                return Get("Restore_Email_Register", resourceCulture);
            }
        }

        public static string Restore_MaimFormLink
        {
            get
            {
                return Get("Restore_MaimFormLink", resourceCulture);
            }
        }

        public static string Restore_Password
        {
            get
            {
                return Get("Restore_Password", resourceCulture);
            }
        }

        public static string Restore_Ph_ConfirmPassword
        {
            get
            {
                return Get("Restore_Ph_ConfirmPassword", resourceCulture);
            }
        }

        public static string Restore_Ph_Password
        {
            get
            {
                return Get("Restore_Ph_Password", resourceCulture);
            }
        }

        public static string Restore_SetPasswordButton
        {
            get
            {
                return Get("Restore_SetPasswordButton", resourceCulture);
            }
        }

        public static string RestoreChangedOK
        {
            get
            {
                return Get("RestoreChangedOK", resourceCulture);
            }
        }

        public static string RestorePasswordChangedError
        {
            get
            {
                return Get("RestorePasswordChangedError", resourceCulture);
            }
        }

        public static string RestoreText
        {
            get
            {
                return Get("RestoreText", resourceCulture);
            }
        }

        public static string RestoreTitle
        {
            get
            {
                return Get("RestoreTitle", resourceCulture);
            }
        }
    }
}

