using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerService.API.Models;

namespace CustomerService.API.Data
{
    public interface ICustomerLedgerRespository
    {
        Task<CustomerLedger> CreateCustomerLedger(CustomerLedger customerLedger);
        CustomerLedger UpdateCustomerLedger(CustomerLedger customerLedger);
        void DeleteCustomerLedger(int customerLedgerId);
        Task<IEnumerable<CustomerLedger>> GetAllCustomerLedger();
        Task<CustomerLedger> GetCustomerLedgerById(int CustomerLedgerId);
    }
}