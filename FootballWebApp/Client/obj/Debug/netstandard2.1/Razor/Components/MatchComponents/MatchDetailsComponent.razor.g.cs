#pragma checksum "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fbfc37f0913888113b77f9938e694b86b830e9a"
// <auto-generated/>
#pragma warning disable 1591
namespace FootballWebApp.Client.Components.MatchComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using FootballWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using FootballWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using FootballWebApp.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
using FootballWebApp.Shared.Entities.Events;

#line default
#line hidden
#nullable disable
    public partial class MatchDetailsComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "match-details");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "match-flexbox home-logo");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 9 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
         if (appState.SelectedMatch.home_logo != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 11 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                       appState.SelectedMatch.home_logo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "alt", true);
            __builder.AddAttribute(10, "height", "100");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 12 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "match-flexbox comp-info");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 15 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
         if (appState.SelectedMatch.competition_logo != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 17 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                       appState.SelectedMatch.competition_logo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "alt", true);
            __builder.AddAttribute(21, "height", "100");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 18 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "            ");
            __builder.OpenElement(24, "h3");
            __builder.AddContent(25, 
#nullable restore
#line 21 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                 appState.SelectedMatch.country

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " - ");
            __builder.AddContent(27, 
#nullable restore
#line 21 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                                                   appState.SelectedMatch.competition_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 22 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "match-flexbox away-logo");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 25 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
         if (appState.SelectedMatch.away_logo != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "            ");
            __builder.OpenElement(35, "img");
            __builder.AddAttribute(36, "src", 
#nullable restore
#line 27 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                       appState.SelectedMatch.away_logo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "alt", true);
            __builder.AddAttribute(38, "height", "100");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 28 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "match-home-team-info match-flexbox");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddContent(46, 
#nullable restore
#line 31 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
              appState.SelectedMatch.home_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "match-info match-flexbox");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddContent(53, 
#nullable restore
#line 34 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
              appState.SelectedMatch.score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddContent(56, 
#nullable restore
#line 35 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
              appState.SelectedMatch.time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "match-away-team-info match-flexbox");
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddContent(63, 
#nullable restore
#line 38 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
              appState.SelectedMatch.away_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n    ");
            __builder.OpenComponent<MatBlazor.MatDivider>(66);
            __builder.AddAttribute(67, "Class", "divider");
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
     if (appState.SelectedMatch.score != null)
    {
        if (HomeList.Count != 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "match-events");
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "events-list");
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 49 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                     foreach (EventDto homeEvent in HomeList)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "home-event event");
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "eventImg-time");
            __builder.AddMarkupContent(82, "\r\n                                ");
            __builder.OpenElement(83, "img");
            __builder.AddAttribute(84, "src", 
#nullable restore
#line 53 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                                           homeEvent.eventImage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                ");
            __builder.OpenElement(86, "div");
            __builder.AddContent(87, 
#nullable restore
#line 54 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                                      homeEvent.time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "player-name");
            __builder.AddContent(92, 
#nullable restore
#line 56 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                                                      homeEvent.player

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 58 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "events-list");
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 61 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                     foreach (EventDto awayEvent in AwayList)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "away-event event");
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.OpenElement(104, "div");
            __builder.AddContent(105, 
#nullable restore
#line 64 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                                  awayEvent.player

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "div");
            __builder.AddMarkupContent(108, "\r\n                                ");
            __builder.OpenElement(109, "img");
            __builder.AddAttribute(110, "src", 
#nullable restore
#line 66 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                                          awayEvent.eventImage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                ");
            __builder.OpenElement(112, "div");
            __builder.AddContent(113, 
#nullable restore
#line 67 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                                      awayEvent.time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 70 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#nullable restore
#line 73 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
        }
        else
        {

        }
    }
    else //then load fixture info
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(120, "        ");
            __builder.OpenElement(121, "div");
            __builder.AddContent(122, 
#nullable restore
#line 81 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
              CountdownTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 82 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Components\MatchComponents\MatchDetailsComponent.razor"
       
    List<Event> events;
    List<Logo> teamLogos;

    List<EventDto> HomeList = new List<EventDto>();
    List<EventDto> AwayList = new List<EventDto>();

    string CountdownTime;
    DateTime FixtureKickOffTime;

    protected override async Task OnInitializedAsync()
    {
        appState.OnChange += StateHasChanged;

        await GetTeamLogos();

        if (appState.SelectedMatch.score != null)
        {
            await GetEvents();
        }
        else
        {
            FixtureTimer();
        }
    }

    private async Task GetEvents()
    {
        events = await Http.PostJsonAsync<List<Event>>("Football/events", appState.SelectedMatch);

        var BlankEvent = new EventDto();
        if (events != null) if (events.Count != 0)
            {
                foreach (Event @event in events)
                {
                    //format the player name so the first name is displayed before the last name
                    int idx = @event.player.LastIndexOf(" ");
                    string playerToAdd;
                    if (idx != -1)
                    {
                        playerToAdd = $"{@event.player.Substring(idx + 1)} {@event.player.Substring(0, idx)}";
                    }
                    else
                    {
                        playerToAdd = @event.player;
                    }

                    string eventImage;
                    switch (@event.@event)
                    {
                        case "GOAL":
                            eventImage = "../../Images/Goal.png";
                            break;
                        case "GOAL_PENALTY":
                            eventImage = "../../Images/Penalty.png";
                            break;
                        case "OWN_GOAL":
                            eventImage = "../../Images/ownGoal.png";
                            break;
                        case "YELLOW_CARD":
                            eventImage = "../../Images/Yellow.png";
                            break;
                        case "RED_CARD":
                            eventImage = "../../Images/Red.png";
                            break;
                        case "YELLOW_RED_CARD":
                            eventImage = "../../Images/YellowRed.png";
                            break;
                        default:
                            eventImage = @event.@event;
                            break;
                    }

                    var EventToAdd = new EventDto
                    {
                        id = @event.id,
                        match_id = @event.match_id,
                        player = playerToAdd,
                        time = @event.time,
                        eventImage = eventImage,
                        sort = @event.sort,
                        home_away = @event.home_away
                    };

                    if (@event.home_away == "h")
                    {
                        HomeList.Insert(0, EventToAdd);
                        AwayList.Insert(0, BlankEvent);
                    }
                    else
                    {
                        AwayList.Insert(0, EventToAdd);
                        HomeList.Insert(0, BlankEvent);
                    }
                }
            }
    }

    private async Task GetTeamLogos()
    {
        teamLogos = await Http.GetJsonAsync<List<Logo>>("Football/teamLogos");

        foreach (var logo in teamLogos)
        {
            if (appState.SelectedMatch.home_name.ToLower() == logo.team_name.ToLower() ||
                appState.SelectedMatch.home_name.Contains(logo.team_name) ||
                $"FC {appState.SelectedMatch.home_name}".Contains(logo.team_name) ||
                $"{appState.SelectedMatch.home_name} FC".Contains(logo.team_name))
            {
                appState.SelectedMatch.home_logo = logo.logo;
            }
            if (appState.SelectedMatch.away_name.ToLower() == logo.team_name.ToLower() ||
                appState.SelectedMatch.away_name.Contains(logo.team_name) ||
                $"FC {appState.SelectedMatch.away_name}".Contains(logo.team_name) ||
                $"{appState.SelectedMatch.away_name} FC".Contains(logo.team_name))
            {
                appState.SelectedMatch.away_logo = logo.logo;
            }
        }
    }

    private void FixtureTimer()
    {
        FixtureKickOffTime = DateTime.Parse($"{appState.SelectedMatch.date} {appState.SelectedMatch.time}");
        if (appState.SelectedMatch.time == "00:00" || appState.SelectedMatch.time == "00:30" || appState.SelectedMatch.time == "01:00")
        {
            FixtureKickOffTime = FixtureKickOffTime.AddDays(1);
        }
        TimeSpan ts = FixtureKickOffTime.Subtract(DateTime.Now);
        string timeLeft = ts.ToString().Split('.')[0];
        CountdownTime = ts.ToString("d' days 'h' hrs 'm' min 's' sec'");

        var timer = new Timer(new TimerCallback(_ =>
        {
            ts = FixtureKickOffTime.Subtract(DateTime.Now);
            timeLeft = ts.ToString().Split('.')[0];
            CountdownTime = ts.ToString("d' days 'h' hrs 'm' min 's' sec'");
            if (timeLeft != "00:00:00")
            {

            this.StateHasChanged();
            }
        }), null, 1000, 1000);
    }

    public void Dispose()
    {
        appState.OnChange -= StateHasChanged;
        this.Dispose();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
