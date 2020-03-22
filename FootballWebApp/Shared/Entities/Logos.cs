using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWebApp.Shared.Entities
{
    public class Logo
    {
        public string team_name { get; set; }
        public string logo { get; set; }
    }

    public class LeagueLogo
    {
        public string name { get; set; }
        public string country_name { get; set; }
        public string logo { get; set; }
        public string flag { get; set; }
    }
}
