#pragma checksum "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd55f5d93538670f7d93de019c1fa62f49105e9"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Ryan\Desktop\Web\Repositories\FootballWebAppBlazor\FootballWebApp\Client\Shared\MainLayout.razor"
 
    private string _searchValue;
    public string SearchValue
    {
        get => _searchValue;
        set
        {
            _searchValue = value;
            this.StateHasChanged();
        }
    }

    private DateTime _dateSelected = DateTime.Now;
    public DateTime DateSelected
    {
        get => _dateSelected;
        set
        {
            _dateSelected = value;
            this.StateHasChanged();
            if (!appState.IsNavOpen) appState.ToggleNav();
        }
    }

    MatTheme MainTheme = new MatTheme()
    {
        Primary = "#263238"
    };

    public string _searchFocused = "width: 60px;";

    private void ToggleSearch(bool focused)
    {
        _searchFocused = (focused) ? "width: 200px;" : "width: 60px;";
        if (focused && !appState.IsNavOpen) appState.ToggleNav();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
    }
}
#pragma warning restore 1591
