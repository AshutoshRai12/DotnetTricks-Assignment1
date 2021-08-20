using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvc.Models
{
    public class CityModel
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
    }
}
