using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWebApp.Shared.Entities
{
    public class Country
    {
        public string id { get; set; }
        public string name { get; set; }
        public string flag { get; set; }
        public List<Competition> competitions { get; set; }
    }
}
