using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API.Customer.Business;
using API.Customer.DTO.Request;
using ServiceStack;

namespace API.Customer.Service
{
    public sealed class CustomerService : ServiceStack.Service,
        IGet<GetCustomer>,
        IDelete<DeleteCustomer>,
        IPut<PutCustomer>,
        IPost<PostCustomer>
    {
        public object Delete(DeleteCustomer request)
        {
            throw new NotImplementedException();
        }

        public object Get(GetCustomer request)
        {
            return new GetCustomerResponse { Result = $"Hello Customer ID = {request.Id}" };
        }
    
        public object Post(PostCustomer request)
        {
            return new CustomerManager().AddCustomer(request.Customer.Id,request.Customer.FirstName, request.Customer.LastName, request.Customer.Number, request.Customer.Email);
        }

        public object Put(PutCustomer request)
        {
            throw new NotImplementedException();
        }
    }
}