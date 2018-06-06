using Funq;
using ServiceStack;
using API.Customer.Service;
using ServiceStack.Validation;
using API.Customer.Validator;

namespace API.Customer
{
    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("API Customer", typeof(CustomerService).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            // Enabling the validation
            Plugins.Add(new ValidationFeature());
            /*
            container.RegisterValidator(typeof(GetCustomerValidator));
            container.RegisterValidator(typeof(PostCustomerValidator));
            container.RegisterValidator(typeof(PutCustomerValidator));
            container.RegisterValidator(typeof(DeleteCustomerValidator));
            */    
        }
    }
}