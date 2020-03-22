using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballWebApp.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using FootballWebApp.Client.Services;
using FootballWebApp.Server.Services;

namespace FootballWebApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IAppDataRepo _appRepo = new AppDataRepo();

        //Match Selected
        [HttpPost("match", Name = "MatchSelected")]
        public Match MatchSelected(Match match)
        {
            _appRepo.AddCurrentMatch(match);
            return match;
        }

        //Get SelectedMatch
        [HttpGet("match", Name = "GetSelectedMatch")]
        public Match GetSelectedMatch()
        {
            var match = _appRepo.GetCurrentMatch();
            return match;
        }
    }
}
