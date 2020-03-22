using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWebApp.Shared.Entities
{
    public class Competition
    {
        public int id { get; set; }
        public string name { get; set; }
        public string is_league { get; set; }
        public string is_cup { get; set; }
        public string tier { get; set; }
        public string has_groups { get; set; }
        public List<Country> countries { get; set; }
        public List<Country> federations { get; set; }
        public List<Match> matches { get; set; }
        public string leagueLogo { get; set; }
    }
}
