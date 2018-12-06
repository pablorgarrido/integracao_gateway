using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YapayGatewayLib.Model
{
    public class Transaction
    {
       [JsonProperty(PropertyName = "codigoEstabelecimento")]
       public string storeCode { get; set; }

       [JsonProperty(PropertyName = "codigoFormaPagamento")]
       public int paymentCode { get; set; }

       [JsonProperty(PropertyName = "transacao")]
       public TransactionData transactionData { get; set; }

       [JsonProperty(PropertyName = "checkout")]
       public CheckoutData checkout { get; set; }

       [JsonProperty(PropertyName = "dadosCartao")]
       public CreditCardData creditCard { get; set; }

       [JsonProperty(PropertyName = "dadosMultiplosCartoes")]
       public List<CreditCardData> multipleCard { get; set; }

       [JsonProperty(PropertyName = "dadosDebito")]
       public DebitCardData debitCard { get; set; }

       [JsonProperty(PropertyName = "itensDoPedido")]
       public List<ItemData> items { get; set; }

       [JsonProperty(PropertyName = "dadosCobranca")]
       public ChargingData charging { get; set; }

       [JsonProperty(PropertyName = "dadosEntrega")]
       public DeliveryData delivery { get; set; }

       [JsonProperty(PropertyName = "dadosAirline")]
       public AirlineData airline { get; set; }

       [JsonProperty(PropertyName = "camposExtras")]
       public List<ExtraField> extraFields { get; set; }
    }
}
