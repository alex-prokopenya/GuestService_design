using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuestService.Models.Countries
{
    public class CountryPartners : SeoObject
    {
        public string CountryName { get; set; }

        public string CountryId { get; set; }

        public KeyValuePair<string, string>[] Providers { get; set; }

        public KeyValuePair<string, string>[] Agents { get; set; }
    }
}
