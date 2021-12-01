using ShopRUsApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopRUsApi.Repository
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerByName(string name);
        Task<Customer> GetCustomerById(int Id);
        Task<Customer> CreateCustomer(Customer customer);
    }
}