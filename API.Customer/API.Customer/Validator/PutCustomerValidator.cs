using API.Customer.DTO.Request;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.Validator
{
    /// <summary>
    /// Request validator : Update a specified customer
    /// </summary>
    public sealed class PutCustomerValidator : AbstractValidator<PutCustomer>
    {
        /// <summary>
        /// Do Validation
        /// </summary>
        public PutCustomerValidator () : base ()
        {
            RuleFor(customer => customer.Id).NotNull().NotEmpty();
            RuleFor(customer => customer.Customer.FirstName).NotNull().NotEmpty().WithMessage("Le prénom doit exister");
            RuleFor(customer => customer.Customer.LastName).NotNull().NotEmpty().WithMessage("Le nom doit exister");
            RuleFor(customer => customer.Customer.Number).Length(10).WithMessage("Numéro à 10 chiffres");
            RuleFor(customer => customer.Customer.Email).EmailAddress();
        }
    }
}