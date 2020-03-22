using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.FluentMap.Mapping;
using FootballWebApp.Shared.Entities;

namespace FootballWebApp.Server.Mapping
{
    internal class MatchMap : EntityMap<Match>
    {
        internal MatchMap()
        {
            Map(m => m.id).ToColumn("Id");
            Map(m => m.date).ToColumn("Date");
            Map(m => m.home_name).ToColumn("HomeName");
            Map(m => m.away_name).ToColumn("AwayName");
            Map(m => m.score).ToColumn("Score");
            Map(m => m.ht_score).ToColumn("HtScore");
            Map(m => m.ft_score).ToColumn("FtScore");
            Map(m => m.et_score).ToColumn("EtScore");
            Map(m => m.time).ToColumn("Time");
            Map(m => m.round).ToColumn("Round");
            Map(m => m.league_id).ToColumn("LeagueId");
            Map(m => m.status).ToColumn("Status");
            Map(m => m.added).ToColumn("Added");
            Map(m => m.last_changed).ToColumn("LastChanged");
            Map(m => m.home_id).ToColumn("HomeId");
            Map(m => m.away_id).ToColumn("AwayId");
            Map(m => m.competition_id).ToColumn("CompetitionId");
            Map(m => m.location).ToColumn("Location");
            Map(m => m.fixture_id).ToColumn("FixtureId");
            Map(m => m.scheduled).ToColumn("Scheduled");
            Map(m => m.events).ToColumn("Events");
            Map(m => m.league_name).ToColumn("LeagueName");
            Map(m => m.competition_name).ToColumn("CompetitionName");
            Map(m => m.home_logo).ToColumn("HomeLogo");
            Map(m => m.away_logo).ToColumn("AwayLogo");
            Map(m => m.competition_logo).ToColumn("CompetitionLogo");
            Map(m => m.country).ToColumn("Country");
        }
    }
}
