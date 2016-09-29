using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheRealLabo3;
using System.Linq;
using System.Data.Entity;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void CanGetCustomers()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customers.ToList().Count);
            }
        }

        private CompanyContext GetContext()
        {
            CompanyContext context = new CompanyContext();
            return context;
        }

        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }
    }
}

