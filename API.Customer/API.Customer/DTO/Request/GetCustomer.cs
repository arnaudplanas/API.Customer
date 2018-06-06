using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.DTO.Request
{
    /// <summary>
    /// Get a specified customer
    /// </summary>
    [Route("/customer/{Id}", Verbs = "GET", Summary = "Return a specified customer")]
    public sealed class GetCustomer : IReturn<Customer>
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        public int Id { get; set; }
    }

    public class GetCustomerResponse
    {
        public string Result { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}