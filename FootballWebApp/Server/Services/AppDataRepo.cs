using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballWebApp.Shared.Entities;
using System.Data.SqlClient;
using Dapper;

namespace FootballWebApp.Server.Services
{
    public class AppDataRepo : IAppDataRepo
    {
        public string connectionString = @"Server=(localdb)\mssqllocaldb;Database=FootballWebAppDB;Trusted_Connection=True;";

        public Match GetCurrentMatch()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var matches = connection.Query<Match>("SELECT * FROM CurrentMatch");
                return matches.Last();
            }
        }

        public Match AddCurrentMatch(Match match)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute("INSERT INTO CurrentMatch VALUES (@ID, @DATE, @HOME_NAME, @AWAY_NAME, @SCORE, @HT_SCORE, @FT_SCORE, @ET_SCORE, @TIME, @ROUND, @LEAGUE_ID, @STATUS, @ADDED, @LAST_CHANGED, @HOME_ID, @AWAY_ID, @COMPETITION_ID, @LOCATION, @FIXTURE_ID, @SCHEDULED, @EVENTS, @LEAGUE_NAME, @COMPETITION_NAME, @HOME_LOGO, @AWAY_LOGO, @COMPETITION_LOGO, @COUNTRY)",
                    new
                    {
                        ID = match.id,
                        DATE = match.date,
                        HOME_NAME = match.home_name,
                        AWAY_NAME = match.away_name,
                        SCORE = match.score,
                        HT_SCORE = match.ht_score,
                        FT_SCORE = match.ft_score,
                        ET_SCORE = match.et_score,
                        TIME = match.time,
                        ROUND = match.round,
                        LEAGUE_ID = match.league_id,
                        STATUS = match.status,
                        ADDED = match.added,
                        LAST_CHANGED = match.last_changed,
                        HOME_ID = match.home_id,
                        AWAY_ID = match.away_id,
                        COMPETITION_ID = match.competition_id,
                        LOCATION = match.location,
                        FIXTURE_ID = match.fixture_id,
                        SCHEDULED = match.scheduled,
                        EVENTS = match.events,
                        LEAGUE_NAME = match.league_name,
                        COMPETITION_NAME = match.competition_name,
                        HOME_LOGO = match.home_logo,
                        AWAY_LOGO = match.away_logo,
                        COMPETITION_LOGO = match.competition_logo,
                        COUNTRY = match.country
                    });
            }

            return match;
        }
    }
}
