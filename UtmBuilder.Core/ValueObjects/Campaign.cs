using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign : ValueObjects
    {
        /// <summary>
        /// Generate a new campain for a URL
        /// </summary>
        /// <param name="medium">marketing medium (e.g cpc, banner)</param>
        /// <param name="name">product, promo code or slogan</param>
        /// <param name="source"> the referrer (e.g. google, newsletter)</param>
        /// <param name="id">the ads campain id</param>
        /// <param name="term">identify the paid keywords</param>
        /// <param name="content">use to differentiate</param>
        public Campaign(string source, 
            string medium, 
            string name, 
            string? id = null, 
            string? term = null, 
            string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;           
            Id = id;
            Term = term;    
            Content = content;

            InvalidCampaignException.ThrowIfInvalidUrl(source, "UTM source is invalid");
            InvalidCampaignException.ThrowIfInvalidUrl(medium, "UTM medium is invalid");
            InvalidCampaignException.ThrowIfInvalidUrl(name, "UTM name is invalid");
        }

        public string? Id { get; }
        public string Source { get; }
        public string Medium { get; }
        public string Name { get; }        
        public string? Term { get;}
        public string? Content { get; }
    }
}
