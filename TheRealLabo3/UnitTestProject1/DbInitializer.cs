using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRealLabo3;

namespace UnitTestProject1
{
    class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            base.Seed(context);
            Customer cust = new Customer()
            {
                Name = "Albert Dupont",
                AddressLine1 = "Rue des cerisiers, 16",
                City = "Arlon",
                Country = "Belgique",
                Email = "info@me.com",
                Id = 3,
                Remark = "Ne pas avoir peur des chiens pour aller chez ce client",
                PostCode = "6700"
            };
            context.Customers.Add(cust);
            context.SaveChanges();
        }
    }
}
