using ServiceStack.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.Business
{
    public sealed class CustomerManager
    {
        protected readonly ILog _log;


        public Customer AddCustomer(int id,string firstName, string lastName, string number, string email)
        {
            return new Customer() { Id = id, FirstName = firstName, LastName = lastName, Number = number, Email = email };
        }

    }
}