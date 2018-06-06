using API.Customer.DTO.Request;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.Validator
{
    /// <summary>
    /// Request validator : Delete a specified Customer
    /// </summary>
    public sealed class DeleteCustomerValidator : AbstractValidator<DeleteCustomer>
    {
        /// <summary>
        /// Do validation
        /// </summary>
        public DeleteCustomerValidator () : base ()
        {
            RuleFor(customer => customer.Id).NotNull().NotEmpty();
        }
    }
}