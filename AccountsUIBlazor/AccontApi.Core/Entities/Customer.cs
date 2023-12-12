namespace AccontApi.Core
{
    public class Customer
    {
        public int? CustomerId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string NickName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public string ReferredBy { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Url { get; set; }

        public bool IsActive { get; set; }
    }
}