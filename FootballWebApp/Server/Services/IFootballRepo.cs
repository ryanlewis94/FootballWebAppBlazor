using FootballWebApp.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballWebApp.Shared.Entities.Events;

namespace FootballWebApp.Server.Services
{
    public interface IFootballRepo
    {
        List<LeagueLogo> GetLeagueLogos();
        List<Logo> GetTeamLogos();
        Task<List<Country>> LoadCountries();
        Task<List<Country>> LoadFederations();
        Task<List<Competition>> LoadCompetitions();
        Task<List<Match>> LoadLiveMatches();
        Task<List<Match>> LoadMatches(string date, int pageNo);
        Task<List<Event>> LoadEvents(string matchId);
        Task<List<Match>> LoadFixtures(string date, int pageNo);
    }
}
