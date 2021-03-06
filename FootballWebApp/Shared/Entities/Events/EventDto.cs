﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FootballWebApp.Shared.Entities.Events
{
    public class EventDto
    {
        public string id { get; set; }
        public string match_id { get; set; }
        public string player { get; set; }
        public string time { get; set; }
        public string eventImage { get; set; }
        public int sort { get; set; }
        public string home_away { get; set; }
    }
}
