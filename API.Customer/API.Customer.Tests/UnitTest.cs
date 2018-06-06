using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using API.Customer;
using API.Customer.Service;

namespace API.Customer.Tests
{
    public class UnitTest
    {
        private readonly ServiceStackHost appHost;

        public UnitTest()
        {
            appHost = new BasicAppHost().Init();
            appHost.Container.AddTransient<CustomerService>();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => appHost.Dispose();

        [Test]
        public void CallCustomerService()
        {
            var service = appHost.Container.Resolve<CustomerService>();

        }
    }
}
