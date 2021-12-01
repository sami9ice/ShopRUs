using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopRUsApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }

    public enum RoleEnum
    {
        Affiliate,Employee
    }
}
