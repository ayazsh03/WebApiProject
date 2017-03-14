using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class Order
    {
        #region Private Variables

        private double _subTotal;
        private double _orderTotal;
        private double _tax;
        private double _shippingCharges;

        #endregion

        #region Properties

        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int PaymentStatusID { get; set; }
        public int TransactionID { get; set; }
        public string TrackingNumber { get; set; }
        public double SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = Math.Round(value, 2); }
        }
        public double OrderTotal
        {
            get { return _orderTotal; }
            set { _orderTotal = Math.Round(value, 2); }
        }
        public double Tax
        {
            get { return _tax; }
            set { _tax = Math.Round(value, 2); }
        }
        public double ShippingCharges
        {
            get { return _shippingCharges; }
            set { _shippingCharges = Math.Round(value, 2); }
        }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string SpecialInstruction { get; set; }

        #endregion
    }
}
