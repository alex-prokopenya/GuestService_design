using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Web;
namespace GuestService.Code.Payment
{
    public class JccPaymentResult
    {
        public enum OpeationStatus
        {
            Failed,
            Success
        }
        public string InvoiceNumber
        {
            get;
            private set;
        }
        public JccPaymentResult.OpeationStatus Status
        {
            get;
            private set;
        }
        public static JccPaymentResult Create(HttpRequestBase request)
        {
            if (request == null)
            {
                throw new System.ArgumentNullException("request");
            }

            string claim = request["order"];
            if (string.IsNullOrEmpty(claim))
            {
                throw new System.Exception("order is empty");
            }

            string orderId = request["OrderID"];
            if (string.IsNullOrEmpty(orderId))
            {
                throw new System.Exception("Order_ID is empty");
            }
            string invoiceNumber = request["invoice"];
            if (string.IsNullOrEmpty(invoiceNumber))
            {
                throw new System.Exception("invoice is empty");
            }

            if (claim + "/" + invoiceNumber != orderId)
            {
                throw new System.Exception("invalid invoice and order number");
            }

            string responseCode = request["ResponseCode"];
            if (string.IsNullOrEmpty(responseCode))
            {
                throw new System.Exception("responseCode is empty");
            }

            string reasonCode = request["ReasonCode"];
            if (string.IsNullOrEmpty(reasonCode))
            {
                throw new System.Exception("ReasonCode is empty");
            }

            string reasonCodeDesc = request["ReasonCodeDesc"];
            if (string.IsNullOrEmpty(reasonCode))
            {
                throw new System.Exception("ReasonCodeDesc is empty");
            }

            string authCode = "";

            if(reasonCode == "1" && responseCode=="1")
                authCode = request["AuthCode"];


            string responseSignature = request["ResponseSignature"];
            if (string.IsNullOrEmpty(responseSignature))
            {
                throw new System.Exception("ResponseSignature is empty");
            }
            
            //$toEncrypt = $password.$merchantID.$acquirerID.$orderID.$ResponseCode.$ReasonCode;
            var result = "";
            string signatureString = string.Format("{0}{1}{2}{3}{4}{5}", ConfigurationManager.AppSettings["jccPassword"],
                                                                         ConfigurationManager.AppSettings["jccMerID"],
                                                                         ConfigurationManager.AppSettings["jccAcqID"],
                                                                         orderId,
                                                                         responseCode,
                                                                         reasonCode);

            byte[] payloadInBytes = System.Text.UTF8Encoding.UTF8.GetBytes(signatureString);

            System.Security.Cryptography.SHA1Managed sha1 = new System.Security.Cryptography.SHA1Managed();
            result = Convert.ToBase64String(sha1.ComputeHash(payloadInBytes));


            if (result != responseSignature)
            {
                throw new System.Exception(string.Format("invalid signature", new object[0]));
            }
            return new JccPaymentResult
            {
                InvoiceNumber = invoiceNumber,
                Status = (responseCode == "1" && reasonCode == "1") ? JccPaymentResult.OpeationStatus.Success : JccPaymentResult.OpeationStatus.Failed
            };
        }
    }
}
