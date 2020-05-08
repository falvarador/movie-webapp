#pragma checksum "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2f0ddc098da5f476c79b52229fcd4a02a7c2d5"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Shared.Commons
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
    public partial class MultiSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "selector-multiple");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "selectable-ul");
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 3 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
         foreach (var item in NotSelected)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
                            () => Select(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, 
#nullable restore
#line 5 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
                                                  item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 6 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "selector-multiple-botones");
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
                                        SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, ">>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
                                        DeselectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 10 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
                                                      removerTodoTexto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "selectable-ul");
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 13 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
         foreach (var item in Selected)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
                            () => Deselect(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, 
#nullable restore
#line 15 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
                                                    item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 16 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelector.razor"
       
    private string removerTodoTexto = "<<";

    [Parameter] public List<MultiSelectorViewModel> NotSelected { get; set; } = new List<MultiSelectorViewModel>();
    [Parameter] public List<MultiSelectorViewModel> Selected { get; set; } = new List<MultiSelectorViewModel>();

    private void Select(MultiSelectorViewModel item)
    {
        NotSelected.Remove(item);
        Selected.Add(item);
    }

    private void Deselect(MultiSelectorViewModel item)
    {
        Selected.Remove(item);
        NotSelected.Add(item);
    }

    private void SelectAll()
    {
        Selected.AddRange(NotSelected);
        NotSelected.Clear();
    }

    private void DeselectAll()
    {
        NotSelected.AddRange(Selected);
        Selected.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
