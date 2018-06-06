using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer
{
    /// <summary>
    /// Customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customer LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Customer Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Customer Number
        /// </summary>
        public string Number { get; set; }
    }
}