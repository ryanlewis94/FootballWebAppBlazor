#pragma checksum "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23be2b706f4fff35b783da6895be78dc14881601"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FootballWebApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using FootballWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using FootballWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using FootballWebApp.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
using FootballWebApp.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
       

    [Parameter]
    public DateTime date { get; set; }

    List<Country> countries;
    List<Country> nestedCountries;
    List<Competition> competitions;
    List<Match> matches;
    List<LeagueLogo> leagueLogos;

    public DateTime TodaysDate = DateTime.Parse(DateTime.Now.ToString().Split(' ')[0]);

    MatTheme MainTheme = new MatTheme()
    {
        Primary = "#43a047"
    };

    protected override void OnInitialized()
    {
        appState.OnChange += StateHasChanged;
    }

    protected override async Task OnParametersSetAsync()
    {
        countries = new List<Country>();


        nestedCountries = (await Http.GetJsonAsync<List<Country>>("Football/countries"))
            .Union(await Http.GetJsonAsync<List<Country>>("Football/federations")).ToList()
            .OrderBy(c => c.name).ToList();

        competitions = (await Http.GetJsonAsync<List<Competition>>("Football/competitions"))
            .OrderBy(c => c.id).ToList();

        //has to be an object to post
        Match dateMatch = new Match()
        {
            date = date.ToString()
        };

        //get fixtures if date is a future date
        if (DateTime.Parse(date.ToString().Split(' ')[0]) > TodaysDate)
        {
            matches = await Http.PostJsonAsync<List<Match>>("Football/fixtures", dateMatch);
        }
        //get live, played and future matches if date is today
        if (DateTime.Parse(date.ToString().Split(' ')[0]) == TodaysDate)
        {
            matches = (await Http.GetJsonAsync<List<Match>>("Football/live"))
                .Union(await Http.PostJsonAsync<List<Match>>("Football/matches", dateMatch))
                .Union(await Http.PostJsonAsync<List<Match>>("Football/fixtures", dateMatch)).ToList();
        }
        //get played matches if date is in the past
        if (DateTime.Parse(date.ToString().Split(' ')[0]) < TodaysDate)
        {
            matches = await Http.PostJsonAsync<List<Match>>("Football/matches", dateMatch);
        }

        leagueLogos = await Http.GetJsonAsync<List<LeagueLogo>>("Football/leagueLogos");

        NestLists();
    }

    private void NestLists()
    {

        try
        {
            foreach (var country in nestedCountries)
            {
                country.competitions = new List<Competition>();
                foreach (var comp in competitions)
                {
                    comp.matches = new List<Match>();
                    if (country.id == ((comp.countries.Count != 0) ? comp.countries[0].id : comp.federations[0].id))
                    {
                        foreach (LeagueLogo logo in leagueLogos)
                        {
                            if (country.name.ToLower() == logo.country_name.ToLower() &&
                                comp.name.ToLower() == logo.name.ToLower())
                            {
                                comp.leagueLogo = logo.logo;
                                country.flag = logo.flag;
                            }
                        }

                        foreach (var match in matches)
                        {
                            if (comp.id == match.competition_id)
                            {
                                match.competition_logo = comp.leagueLogo;
                                match.country = country.name;
                                if(match.time.Length > 4) match.time = match.time.Substring(0,5);
                                comp.matches.Add(match);
                            }
                        }
                        if (comp.matches.Count != 0)
                        {
                            country.competitions.Add(comp);
                        }
                    }
                }
            }
            countries = nestedCountries.Where(country => country.competitions.Count != 0).ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void NavToggle(Match match)
    {
        appState.SetCurrentMatch(match);
        navigationManager.NavigateTo($"match");
        appState.ToggleNav();
    }

    public void Dispose()
    {
        appState.OnChange -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591