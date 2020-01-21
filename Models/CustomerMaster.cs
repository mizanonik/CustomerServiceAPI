using System;
using System.Threading.Tasks;

namespace CustomerService.API.Models
{
    public class CustomerMaster
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }
        public DateTime LastTransactionDate { get; set; }

        public static explicit operator CustomerMaster(Task<CustomerMaster> v)
        {
            throw new NotImplementedException();
        }
    }
}