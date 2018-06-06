using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.DTO.Request
{
    /// <summary>
    /// Delete a specified customer
    /// </summary>
    [Route("/customer/{Id}", Verbs = "DELETE", Summary = "Delete a specified customer")]
    public sealed class DeleteCustomer : IReturnVoid
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        public int Id { get; set; }
    }
}