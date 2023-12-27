namespace AccountsUIBlazor.UIModels
{
    public class UICustomerPayment
    {
        public List<CustomerList> CustomerList { get; set; }
        public int CustomerId { get; set; }
        public int AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }

        public string Comments { get; set; }
    }

    public class CustomerList
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
