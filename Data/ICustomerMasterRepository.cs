using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerService.API.Models;

namespace CustomerService.API.Data
{
    public interface ICustomerMasterRepository
    {
        Task<CustomerMaster> CreateCustomer(CustomerMaster customerMaster);
        CustomerMaster EditCustomer(CustomerMaster customerMaster);
        void DeleteCustomer(int customerId);
        Task<List<CustomerMaster>> GetCustomers();
        Task<CustomerMaster> GetCustomer(int CustomerId);         
    }
}