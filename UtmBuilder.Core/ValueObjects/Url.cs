using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;
using static System.Net.WebRequestMethods;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObjects
    {
        

        /// Create a new URL
        /// </summary>
        /// <param name="address">Address of URL(Website Link)</param>
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalidUrl(address);
        }

        /// <summary>
        /// Address of URL (Website Link)
        /// </summary>
        public string Address { get; }
    }
}
