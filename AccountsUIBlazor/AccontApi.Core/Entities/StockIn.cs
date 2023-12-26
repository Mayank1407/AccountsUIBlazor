namespace AccountApi.Core
{
    public class StockIn
    {
       // public VendorNames VendorNames { get; set; }
        public int StockInId { get; set; }
        public string LoadName { get; set; }
        public int VendorId { get; set; }
        public int Quantity { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
