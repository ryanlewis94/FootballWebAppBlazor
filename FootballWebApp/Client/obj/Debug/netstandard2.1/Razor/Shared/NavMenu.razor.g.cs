#pragma checksum "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23be2b706f4fff35b783da6895be78dc14881601"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "Class", (
#nullable restore
#line 7 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
              (appState.IsNavOpen) ? "navOpen" : "navClosed"

#line default
#line hidden
#nullable disable
            ) + " myNav");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
     if (countries.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
         try
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "            ");
            __builder.OpenComponent<MatBlazor.MatThemeProvider>(6);
            __builder.AddAttribute(7, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTheme>(
#nullable restore
#line 16 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                      MainTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatNavMenu>(10);
                __builder2.AddAttribute(11, "Multi", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n");
#nullable restore
#line 18 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                     foreach (var country in countries)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(14, "                        ");
                    __builder3.OpenComponent<MatBlazor.MatNavSubMenu>(15);
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(17, "\r\n                            ");
                        __builder4.OpenComponent<MatBlazor.MatNavSubMenuHeader>(18);
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(20, "\r\n                                ");
                            __builder5.OpenComponent<MatBlazor.MatNavItem>(21);
                            __builder5.AddAttribute(22, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                            false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(24, "\r\n");
#nullable restore
#line 23 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                     if (country.flag != null)
                                    {

#line default
#line hidden
#nullable disable
                                __builder6.AddContent(25, "                                        ");
                                __builder6.OpenElement(26, "img");
                                __builder6.AddAttribute(27, "src", 
#nullable restore
#line 25 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                   country.flag

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddAttribute(28, "alt", true);
                                __builder6.AddAttribute(29, "height", "30");
                                __builder6.AddAttribute(30, "width", "30");
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(31, "\r\n");
#nullable restore
#line 26 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                                __builder6.AddMarkupContent(32, "                                        <div style=\"width: 30px; height: 30px;\"></div>\r\n");
#nullable restore
#line 30 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                    }

#line default
#line hidden
#nullable disable
                                __builder6.AddMarkupContent(33, "                                    &nbsp;\r\n                                    ");
                                __builder6.AddContent(34, 
#nullable restore
#line 32 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                     country.name

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(35, "\r\n                                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(36, "\r\n                            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n\r\n                            ");
                        __builder4.OpenComponent<MatBlazor.MatNavSubMenuList>(38);
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(40, "\r\n");
#nullable restore
#line 37 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                 foreach (var comp in @country.competitions)
                                {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(41, "                                    ");
                            __builder5.OpenComponent<MatBlazor.MatNavSubMenu>(42);
                            __builder5.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(44, "\r\n                                        ");
                                __builder6.OpenComponent<MatBlazor.MatNavSubMenuHeader>(45);
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(47, "\r\n                                            ");
                                    __builder7.OpenComponent<MatBlazor.MatNavItem>(48);
                                    __builder7.AddAttribute(49, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                        false

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(51, "\r\n");
#nullable restore
#line 42 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                 if (@comp.leagueLogo != null)
                                                {

#line default
#line hidden
#nullable disable
                                        __builder8.AddContent(52, "                                                    ");
                                        __builder8.OpenElement(53, "img");
                                        __builder8.AddAttribute(54, "src", 
#nullable restore
#line 44 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                               comp.leagueLogo

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.AddAttribute(55, "alt", true);
                                        __builder8.AddAttribute(56, "height", "30");
                                        __builder8.AddAttribute(57, "width", "30");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(58, "\r\n");
#nullable restore
#line 45 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                                        __builder8.AddMarkupContent(59, "                                                    <div style=\"width: 30px; height: 30px;\"></div>\r\n");
#nullable restore
#line 49 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                }

#line default
#line hidden
#nullable disable
                                        __builder8.AddMarkupContent(60, "                                                &nbsp;\r\n                                                ");
                                        __builder8.AddContent(61, 
#nullable restore
#line 51 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                 comp.name

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.AddMarkupContent(62, "\r\n                                            ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(63, "\r\n                                        ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(64, "\r\n\r\n                                        ");
                                __builder6.OpenComponent<MatBlazor.MatNavSubMenuList>(65);
                                __builder6.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(67, "\r\n");
#nullable restore
#line 56 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                             foreach (var match in matches)
                                            {
                                                if (comp.id == match.competition_id)
                                                {
                                                    string homeGoals = (match.score != null) ? match.score[0].ToString() : "";
                                                    string awayGoals = (match.score != null) ? match.score[4].ToString() : "";

#line default
#line hidden
#nullable disable
                                    __builder7.AddContent(68, "                                                    ");
                                    __builder7.OpenComponent<MatBlazor.MatNavItem>(69);
                                    __builder7.AddAttribute(70, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                           (e) => NavToggle(@match)

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.AddAttribute(71, "Style", "margin: 5px 0;");
                                    __builder7.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(73, "\r\n                                                        ");
                                        __builder8.OpenElement(74, "div");
                                        __builder8.AddAttribute(75, "class", "grid-match-nav");
                                        __builder8.AddMarkupContent(76, "\r\n                                                            ");
                                        __builder8.OpenElement(77, "div");
                                        __builder8.AddAttribute(78, "class", "match-time-nav");
                                        __builder8.AddMarkupContent(79, "\r\n                                                                ");
                                        __builder8.OpenElement(80, "div");
#nullable restore
#line 65 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                      if (match.scheduled != null) {

#line default
#line hidden
#nullable disable
                                        __builder8.AddContent(81, 
#nullable restore
#line 65 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                                                     match.scheduled

#line default
#line hidden
#nullable disable
                                        );
#nullable restore
#line 65 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                                                                    }

#line default
#line hidden
#nullable disable
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(82, "\r\n                                                                ");
                                        __builder8.OpenElement(83, "div");
                                        __builder8.AddContent(84, 
#nullable restore
#line 66 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                      match.time

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(85, "\r\n                                                            ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(86, "\r\n                                                            ");
                                        __builder8.OpenElement(87, "div");
                                        __builder8.AddAttribute(88, "class", "match-team-nav");
                                        __builder8.AddMarkupContent(89, "\r\n                                                                ");
                                        __builder8.OpenElement(90, "div");
                                        __builder8.AddContent(91, 
#nullable restore
#line 69 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                      match.home_name

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(92, "\r\n                                                                ");
                                        __builder8.OpenElement(93, "div");
                                        __builder8.AddContent(94, 
#nullable restore
#line 70 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                      match.away_name

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(95, "\r\n                                                            ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(96, "\r\n                                                            ");
                                        __builder8.OpenElement(97, "div");
                                        __builder8.AddAttribute(98, "class", "match-score-nav");
                                        __builder8.AddMarkupContent(99, "\r\n                                                                ");
                                        __builder8.OpenElement(100, "div");
                                        __builder8.AddContent(101, 
#nullable restore
#line 73 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                      homeGoals

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(102, "\r\n                                                                ");
                                        __builder8.OpenElement(103, "div");
                                        __builder8.AddContent(104, 
#nullable restore
#line 74 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                                      awayGoals

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(105, "\r\n                                                            ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(106, "\r\n                                                        ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(107, "\r\n                                                    ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(108, "\r\n");
#nullable restore
#line 78 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                                }
                                            }

#line default
#line hidden
#nullable disable
                                    __builder7.AddContent(109, "                                        ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(110, "\r\n                                    ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\r\n");
#nullable restore
#line 82 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                                }

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(112, "                            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(113, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\r\n                        ");
                    __builder3.OpenComponent<MatBlazor.MatDivider>(115);
                    __builder3.AddAttribute(116, "Style", "background-color: grey");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\r\n");
#nullable restore
#line 86 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(118, "                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 89 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\RY209294\source\repos\FootballWebApp\FootballWebApp\Client\Shared\NavMenu.razor"
         

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
