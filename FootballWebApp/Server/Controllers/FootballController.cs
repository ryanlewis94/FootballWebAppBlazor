using System;
using FootballWebApp.Server.Services;
using FootballWebApp.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballWebApp.Shared.Entities.Events;

namespace FootballWebApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballController : ControllerBase
    {
        private IFootballRepo _footballRepo;

        public FootballController()
        {
            _footballRepo = new FootballRepo();
        }

        //Get a list of countries
        [HttpGet("countries", Name = "GetCountries")]
        [HttpHead]
        public async Task<List<Country>> GetCountries()
        {
            return await _footballRepo.LoadCountries();
        }

        //Get a list of federations
        [HttpGet("federations", Name = "GetFederations")]
        [HttpHead]
        public async Task<List<Country>> GetFederations()
        {
            return await _footballRepo.LoadFederations();
        }

        //Get a list of comps
        [HttpGet("competitions", Name = "GetCompetitions")]
        [HttpHead]
        public async Task<List<Competition>> GetCompetitions()
        {
            return await _footballRepo.LoadCompetitions();
        }

        //Get a list of live games
        [HttpGet("live", Name = "GetLive")]
        [HttpHead]
        public async Task<List<Match>> GetLiveMatches()
        {
            return await _footballRepo.LoadLiveMatches();
        }

        //Get a list of played games
        [HttpPost("matches", Name = "GetMatches")]
        public async Task<List<Match>> GetMatches(Match date)
        {
            var prevMatches = new List<Match>();
            var matchesToReturn = new List<Match>();

            int i = 0;
            do
            {
                i = i + 1;
                prevMatches = await _footballRepo.LoadMatches(date.date, i);
                matchesToReturn = matchesToReturn.Concat(prevMatches).ToList();

            } while (prevMatches.Count == 30);

            return matchesToReturn;
        }

        [HttpPost("events", Name = "GetEvents")]
        public async Task<List<Event>> GetEvents(Match match)
        {
            List<Event> eventsToReturn = new List<Event>();
            if (match.score != null)
            {
                eventsToReturn = await _footballRepo.LoadEvents(match.id);
                return eventsToReturn;
            }
            else
            {
                return eventsToReturn;
            }
        }

        //Get a list of future games
        [HttpPost("fixtures", Name = "GetFixtures")]
        public async Task<List<Match>> GetFixtures(Match date)
        {
            var prevFixtures = new List<Match>();
            var fixturesToReturn = new List<Match>();

            int i = 0;
            do
            {
                i = i + 1;
                prevFixtures = await _footballRepo.LoadFixtures(date.date, i);
                fixturesToReturn = fixturesToReturn.Concat(prevFixtures).ToList();

            } while (prevFixtures.Count == 30);

            return fixturesToReturn;
        }

        [HttpGet("leagueLogos", Name = "GetLeagueLogos")]
        [HttpHead]
        public List<LeagueLogo> LeagueLogos()
        {
            return _footballRepo.GetLeagueLogos();
        }

        [HttpGet("teamLogos", Name = "GetTeamLogos")]
        [HttpHead]
        public List<Logo> TeamLogos()
        {
            return _footballRepo.GetTeamLogos();
        }
    }
}
