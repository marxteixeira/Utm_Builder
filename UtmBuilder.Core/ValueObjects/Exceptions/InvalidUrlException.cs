using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public class InvalidUrlException : Exception
    {
        private const string DefaultErrorMessage = "Invalid URL";
        private const string UrlRegexPattern = @"^((http | ftp | https | www)://)?([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$";

        public InvalidUrlException(string message = DefaultErrorMessage) : base(message)  
        {

        }

        public static void ThrowIfInvalidUrl(string address, string message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(address))
                throw new InvalidUrlException(message);

            if (Regex.IsMatch(address, UrlRegexPattern))
                throw new InvalidUrlException();
        }
    }
}
