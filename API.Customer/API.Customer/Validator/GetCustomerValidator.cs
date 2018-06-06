using API.Customer.DTO.Request;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.Validator
{
    /// <summary>
    /// Request validator : Get a specified customer
    /// </summary>
    public sealed class GetCustomerValidator : AbstractValidator<GetCustomer>
    {
        /// <summary>
        /// Do validator
        /// </summary>
        public GetCustomerValidator() : base()
        {
            RuleFor(customer => customer.Id).NotNull().NotEmpty();
        }
    }
}