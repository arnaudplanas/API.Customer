using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.DTO.Request
{
    /// <summary>
    /// Update a specified Customer
    /// </summary>
    [Route("/customer/{Id}", "PUT")]
    public sealed class PutCustomer : IReturn<Customer>
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer
        /// </summary>
        public Customer Customer { get; set; }
    }
}