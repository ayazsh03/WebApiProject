using LuckyMasale.Shared.DTO;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayPal;
using LuckyMasale.DAL.DataProviders;

namespace LuckyMasale.BAL.Managers
{
    public interface IPayPalManager
    {
        Task<Payment> RunSample(PaymentInformation paymentInformation);
    }

    public class PayPalManager : IPayPalManager
    {       
        public async Task<Payment> RunSample(PaymentInformation paymentInformation)
        {
            APIContext apiContext = Configuration.GetAPIContext("");
            Transaction transaction = new Transaction();
            Transaction transaction2 = transaction;

            Amount amount = new Amount();
            amount.currency = "USD";
            amount.total = paymentInformation.Total;

            Amount amount2 = amount;
            Details details = new Details();
            details.shipping = paymentInformation.Shipping;
            details.subtotal = paymentInformation.SubTotal;
            details.tax = paymentInformation.Tax;

            Details details2 = details;
            amount2.details = details2;

            Amount amount3 = amount;

            ((CartBase)transaction2).amount = amount3;
            ((CartBase)transaction).description = paymentInformation.Description;

            Transaction transaction3 = transaction;
            ItemList itemList = new ItemList();
            ItemList itemList2 = itemList;
            ShippingAddress shippingAddress = new ShippingAddress();

            ((BaseAddress)shippingAddress).city = paymentInformation.SCity;
            ((BaseAddress)shippingAddress).country_code = paymentInformation.SCountryCode;
            ((BaseAddress)shippingAddress).line1 = paymentInformation.SAddress;
            ((BaseAddress)shippingAddress).postal_code = paymentInformation.SCountryCode;
            ((BaseAddress)shippingAddress).state = paymentInformation.SState;
            shippingAddress.recipient_name = paymentInformation.SReceiverName;

            ShippingAddress shippingAddress2 = shippingAddress;

            itemList2.shipping_address = shippingAddress2;

            ItemList itemList3 = itemList;

            ((CartBase)transaction3).item_list = itemList3;
            ((CartBase)transaction).invoice_number = Common.GetRandomInvoiceNumber();

            Transaction transaction4 = transaction;
            Payer payer = new Payer();
            payer.payment_method = "credit_card";

            Payer payer2 = payer;
            List<FundingInstrument> list = new List<FundingInstrument>();
            List<FundingInstrument> list2 = list;
            FundingInstrument fundingInstrument = new FundingInstrument();
            FundingInstrument fundingInstrument2 = fundingInstrument;
            CreditCard creditCard = new CreditCard();
            CreditCard creditCard2 = creditCard;
            Address address = new Address();

            ((BaseAddress)address).city = paymentInformation.BCity;
            ((BaseAddress)address).country_code = paymentInformation.BCountry;
            ((BaseAddress)address).line1 = paymentInformation.BAddress;
            ((BaseAddress)address).postal_code = paymentInformation.BPostal;
            ((BaseAddress)address).state = paymentInformation.SState;

            Address address2 = address;

            creditCard2.billing_address = address2;
            creditCard.cvv2 = paymentInformation.CVV2;
            creditCard.expire_month = paymentInformation.expire_month;
            creditCard.expire_year = paymentInformation.expire_year;
            creditCard.first_name = paymentInformation.first_name;
            creditCard.last_name = paymentInformation.last_name;
            creditCard.number = paymentInformation.number;
            creditCard.type = paymentInformation.type;

            CreditCard creditCard3 = creditCard;

            fundingInstrument2.credit_card = creditCard3;

            FundingInstrument fundingInstrument3 = fundingInstrument;
            list2.Add(fundingInstrument3);

            List<FundingInstrument> list3 = list;
            payer2.funding_instruments = list3;

            Payer payer3 = payer;
            PayerInfo payerInfo = new PayerInfo();
            payerInfo.email = paymentInformation.EmailID;

            PayerInfo payerInfo2 = payerInfo;
            payer3.payer_info = payerInfo2;

            Payer payer4 = payer;
            Payment payment = new Payment();
            payment.intent = "sale";
            payment.payer = payer4;

            Payment payment2 = payment;
            List<Transaction> list4 = new List<Transaction>();
            list4.Add(transaction4);

            List<Transaction> list5 = list4;
            payment2.transactions = list5;

            Payment payment3 = payment;

            try
            {
                return payment3.Create(apiContext);
            }
            catch (PaymentsException ex)
            {
                Payment payment4 = new Payment();
                payment4.state = ex.Details.message;

                return payment4;
            }
        }
    }
}
