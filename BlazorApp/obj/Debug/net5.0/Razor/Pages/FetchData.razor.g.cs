#pragma checksum "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fff0d89401972ff37bf85d55053de3ba7c75042"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Players</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 11 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
 if (teams == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n                <th>Name</th>\r\n                <th>Firstname</th>\r\n                <th>Numero</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 27 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
             foreach (var player in teams)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 30 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
                         player.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 31 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
                         player.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
                         player.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 33 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
                         player.Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\gault\Desktop\Efficom\Master\dotnet\Projet-fullstack-dotnet\BlazorApp\Pages\FetchData.razor"
       
    private Player[] teams;

    protected override async Task OnInitializedAsync()
    {
        teams =  await Http.GetFromJsonAsync<Player[]>("https://localhost:5001/Player");
    }

    public class Player
    {
        public int Id { get; set;}

        public string Name { get; set; }

        public string Firstname { get; set; }

        public int Number { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
