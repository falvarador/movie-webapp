#pragma checksum "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Pages/Movies/UpdateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9f01ff917f7aef758b81a6a72ef9c2a4b9e3ba"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using MovieWeb.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/_Imports.razor"
using MovieWeb.WebApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/update/{MovieId:int}")]
    public partial class UpdateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Update movie</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Pages/Movies/UpdateMovie.razor"
       
    
    [Parameter] 
    public int MovieId { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
