using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWebApp.Shared.Entities
{
    public class ApiData
    {
        public List<Country> country { get; set; }
        public List<Country> federation { get; set; }
        public List<Competition> competition { get; set; }
        public List<Match> match { get; set; }
        public List<Match> fixtures { get; set; }
    }
}
