using System.ComponentModel.DataAnnotations;

namespace AccountApi.Core
{
    public class VendorExpensesPayment
    {
        public int VendorExpensesPaymentId { get; set; }
        public int VendorId { get; set; }
        public int StockInId { get; set; }
        public string ExpensesName { get; set; }

        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Comments { get; set; }

    }
}
