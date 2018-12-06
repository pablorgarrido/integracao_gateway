using System;
using YapayGatewayLib.Model;

namespace YapayGatewayLib.Communication
{
    public class RestV3
    {
        public string TransactionAuthorize(Credential credential, Transaction transaction)
        {
            return null;
        }

        public string TransactionQuery(Credential credential, string storeCode, long transactionNumber)
        {
            return null;
        }

        public string TransactionCapture(Credential credential, string storeCode, long transactionNumber, long value)
        {
            return null;
        }

        public string TransactionCancel(Credential credential, string storeCode, long transactionNumber, long value)
        {
            return null;
        }

        public string OneClickRegister(Credential credential, OneClickRegisterData registerData)
        {
            return null;
        }

        public string OneClickQuery(Credential credential, string token)
        {
            return null;
        }

        public string OneClickRegisterUpdate(Credential credential, string token, OneClickRegisterData registerData)
        {
            return null;
        }

        public string OneClickAuthorize(Credential credential, string token, Transaction transaction)
        {
            return null;
        }

        public string RecurringPaymentRegister(Credential credential, RecurringPayment recurringPayment)
        {
            return null;
        }

        public string RecurringPaymentQuery(Credential credential, string storeCode, long recurringPaymentNumber)
        {
            return null;
        }

        public string RecurringPaymentCancel(Credential credential, string storeCode, long recurringPaymentNumber)
        {
            return null;
        }
    }
}