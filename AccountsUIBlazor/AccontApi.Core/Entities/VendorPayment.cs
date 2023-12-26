using System.ComponentModel.DataAnnotations;

namespace AccountApi.Core
{
    public class VendorPayment
    {
        public int VendorPaymentId { get; set; }
        public int VendorId { get; set; }
        public int StockInId { get; set; }
        public string ElectronicPaymentId { get; set; }
        public string PaymentType { get; set; }

        //if customer made that payment for convient sake
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Comments { get; set; }

    }
}
