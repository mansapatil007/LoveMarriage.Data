using System;
using System.Collections.Generic;

namespace LoveMarriage.Data.Models
{
    public partial class XCountries
    {
        public int CountryId { get; set; }
        public string CountryShortName { get; set; }
        public string CountryName { get; set; }
        public int CountryPhoneCode { get; set; }
    }
}
