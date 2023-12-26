using System.ComponentModel.DataAnnotations;

namespace AccountApi.Core
{
    public class Sales
    {
        public int SalesId { get; set; }
        public int StockInId { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public int VendorId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int CustomerId { get; set; }

    }
}
