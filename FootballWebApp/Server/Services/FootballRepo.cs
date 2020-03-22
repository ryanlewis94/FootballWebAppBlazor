using FootballWebApp.Server.Services.Api;
using FootballWebApp.Shared.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using FootballWebApp.Shared.Entities.Events;
using Newtonsoft.Json;

namespace FootballWebApp.Server.Services
{
    public class FootballRepo : IFootballRepo
    {
        public List<LeagueLogo> GetLeagueLogos()
        {
            using (StreamReader r = new StreamReader(@"..\..\FootballWebApp\Server\Resources\league_list.json"))
            {
                string json = r.ReadToEnd();
                List<LeagueLogo> leagues = JsonConvert.DeserializeObject<List<LeagueLogo>>(json);
                return leagues;
            }
        }

        public List<Logo> GetTeamLogos()
        {
            using (StreamReader r = new StreamReader(@"..\..\FootballWebApp\Server\Resources\team_list.json"))
            {
                string json = r.ReadToEnd();
                List<Logo> teams = JsonConvert.DeserializeObject<List<Logo>>(json);
                return teams;
            }
        }

        public async Task<List<Country>> LoadCountries()
        {
            string url = $"https://livescore-api.com/api-client/countries/list.json?key=oLqHGs5JqQlW14fL&secret=qgXLZ2ODw5KYNcAbX0TEtZoTPJQRN5Dd";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    ApiModel country = stream.ReadAndDeserializeFromJson<ApiModel>();

                    return country?.data?.country;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }

        public async Task<List<Country>> LoadFederations()
        {
            string url = $"https://livescore-api.com/api-client/federations/list.json?key=oLqHGs5JqQlW14fL&secret=qgXLZ2ODw5KYNcAbX0TEtZoTPJQRN5Dd";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    ApiModel federation = stream.ReadAndDeserializeFromJson<ApiModel>();

                    return federation?.data?.federation;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }

        public async Task<List<Competition>> LoadCompetitions()
        {
            string url = $"https://livescore-api.com/api-client/competitions/list.json?key=oLqHGs5JqQlW14fL&secret=qgXLZ2ODw5KYNcAbX0TEtZoTPJQRN5Dd";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    ApiModel competition = stream.ReadAndDeserializeFromJson<ApiModel>();

                    return competition?.data?.competition;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }

        public async Task<List<Match>> LoadLiveMatches()
        {
            string url = $"https://livescore-api.com/api-client/scores/live.json?key=oLqHGs5JqQlW14fL&secret=qgXLZ2ODw5KYNcAbX0TEtZoTPJQRN5Dd";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    ApiModel match = stream.ReadAndDeserializeFromJson<ApiModel>();

                    return match?.data?.match;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }

        public async Task<List<Match>> LoadMatches(string date, int pageNo)
        {
            var matchDate = "";
            if (date != null)
            {
                string[] currentDate = date.ToString().Split(' ');
                string[] convertedDate = currentDate[0].Split('/');
                matchDate = $"{convertedDate[2]}-{convertedDate[1]}-{convertedDate[0]}";
            }

            string url = $"http://livescore-api.com/api-client/scores/history.json?key=oLqHGs5JqQlW14fL&secret=qgXLZ2ODw5KYNcAbX0TEtZoTPJQRN5Dd&from={matchDate}&to={matchDate}&page={pageNo}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    ApiModel match = stream.ReadAndDeserializeFromJson<ApiModel>();

                    return match?.data?.match;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }

        public async Task<List<Event>> LoadEvents(string matchId)
        {
            string url = $"https://livescore-api.com/api-client/scores/events.json?key=oLqHGs5JqQlW14fL&secret=qgXLZ2ODw5KYNcAbX0TEtZoTPJQRN5Dd&id={matchId}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    Events @event = stream.ReadAndDeserializeFromJson<Events>();

                    return @event?.data?.@event;

                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }

        public async Task<List<Match>> LoadFixtures(string date, int pageNo)
        {
            var fixtureDate = "";
            if (date != null)
            {
                string[] currentDate = date.ToString().Split(' ');
                string[] convertedDate = currentDate[0].Split('/');
                fixtureDate = $"{convertedDate[2]}-{convertedDate[1]}-{convertedDate[0]}";
            }

            string url = $"https://livescore-api.com/api-client/fixtures/matches.json?key=oLqHGs5JqQlW14fL&secret=qgXLZ2ODw5KYNcAbX0TEtZoTPJQRN5Dd&date={fixtureDate}&page={pageNo}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    ApiModel match = stream.ReadAndDeserializeFromJson<ApiModel>();

                    return match?.data?.fixtures;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }
    }
}
