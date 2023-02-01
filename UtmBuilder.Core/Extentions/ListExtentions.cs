using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.Extentions
{
    public static class ListExtentions
    {
        public static void AddIfNotNull(
            this List<string> list,
            string key,
            string? value)
        {
            if (!string.IsNullOrEmpty(value))
                list.Add($"{key}={value}");
        }
    }
    
}
