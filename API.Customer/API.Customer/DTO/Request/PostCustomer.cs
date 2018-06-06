using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.DTO.Request
{
    /// <summary>
    /// Create a new customer
    /// </summary>
    [Route("/customer", Verbs = "POST", Summary = "Create a customer")]
    public sealed class PostCustomer : IReturn<Customer>
    {
        /// <summary>
        /// Customer
        /// </summary>
        public Customer Customer { get; set; }
    }
}