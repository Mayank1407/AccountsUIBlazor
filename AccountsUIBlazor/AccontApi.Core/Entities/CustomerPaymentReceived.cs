using System.ComponentModel.DataAnnotations;

namespace AccountApi.Core
{
    public class CustomerPaymentReceived
    {
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
       
    }
}
