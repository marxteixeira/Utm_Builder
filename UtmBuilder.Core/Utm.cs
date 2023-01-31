using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
    public class Utm
    {
        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;    
        }

        /// <summary>
        /// URL (website link)
        /// </summary>
        public Url Url { get; init; }
        /// <summary>
        /// campain details
        /// </summary>
        public Campaign Campaign { get; init; }

    }
}
