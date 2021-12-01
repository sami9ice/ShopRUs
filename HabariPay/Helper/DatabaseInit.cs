using ShopRUsApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopRUsApi.Helper
{
    public class DatabaseInit
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            try
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope())
                {
                    ShopContext context = serviceScope.ServiceProvider.GetService<ShopContext>();
                    context.Database.Migrate();
                    if (!context.Customers.Any())
                    {
                        context.Customers.Add(new Customer() { CustomerName = "Samuel" , Role= RoleEnum.Affiliate.ToString(), CreatedDate = DateTime.Now.AddYears(-4) });

                        context.Customers.Add(new Customer() { CustomerName = "Shola", Role = RoleEnum.Affiliate.ToString(), CreatedDate = DateTime.Now.AddYears(-1) });

                        context.Customers.Add(new Customer() { CustomerName = "Prince", Role = RoleEnum.Employee.ToString()});
                    }

                    if (!context.Discounts.Any())
                    {
                        context.Discounts.Add(new Discount { Percentage = 10, Type = RoleEnum.Affiliate.ToString() });
                        context.Discounts.Add(new Discount { Percentage = 30, Type = RoleEnum.Employee.ToString() });
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
