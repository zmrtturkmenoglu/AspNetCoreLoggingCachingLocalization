using System.Collections.Generic;

namespace AspNetCoreLoggingCachingLocalization.Models
{
    public class CustomerModel
    {
        public List<Customer> Customers { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}