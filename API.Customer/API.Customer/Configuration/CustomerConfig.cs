using ServiceStack;
using System;
using ServiceStack.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Customer.Configuration
{
    public static class CustomerConfig
    {
        /// <summary>
        /// Customer Cache Duration
        /// </summary>
        internal static TimeSpan CacheDuration
        {
            get { return HostContext.TryResolve<IAppSettings>().Get("Customer.CacheDuration", new TimeSpan(0, 45, 0)); }
        }

        /// <summary>
        /// Customer Allowed Users
        /// </summary>
        internal static IList<string> AllowedUsers
        {
            get { return HostContext.TryResolve<IAppSettings>().GetList("Customer.AllowedUsers"); }
        }

    }
}