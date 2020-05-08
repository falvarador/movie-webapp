#pragma checksum "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d440c579c5d4e084f8ca7aa349a4362da9d8df19"
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
    public partial class MultiSelectorTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.WebApp.Shared.Commons.MultiSelectorTypeahead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#nullable restore
#line 3 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
                                 (string value) => SearchMethod(value)

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 4 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
                            sampleItem

#line default
#line hidden
#nullable disable
            , 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
                                    (T item) => SelectElement(item)

#line default
#line hidden
#nullable disable
            ), 4, (context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n        ");
                __builder2.AddContent(6, 
#nullable restore
#line 7 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
         MyResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(7, "\n    ");
            }
            );
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "class", "list-group");
            __builder.AddMarkupContent(11, "\n");
#nullable restore
#line 12 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
     foreach (var item in SelectElements)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "draggable", "true");
            __builder.AddAttribute(15, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 15 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
                            () => HandleDragStart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 16 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
                           () => HandleDragOver(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "list-group-item list-group-item-action");
            __builder.AddMarkupContent(18, "\n            ");
            __builder.AddContent(19, 
#nullable restore
#line 18 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
             MyListTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
                              () => SelectElements.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "badge badge-primary badge-pill");
            __builder.AddAttribute(24, "style", "cursor: pointer");
            __builder.AddContent(25, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 23 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/falvarador/Development/repos/movieWeb/WebApp/src/Shared/Commons/MultiSelectorTypeahead.razor"
       

    [Parameter] public List<T> SelectElements { get; set; } = new List<T>();
    [Parameter] public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    [Parameter] public RenderFragment<T> MyListTemplate { get; set; }

    T sampleItem = default(T);
    T dragItem;

    private void HandleDragStart(T item)
    {
        dragItem = item;
    }

    private void HandleDragOver(T item)
    {
        if (!item.Equals(dragItem))
        {
            var index = SelectElements.IndexOf(dragItem);
            var element = SelectElements.IndexOf(item);
            SelectElements[element] = dragItem;
            SelectElements[index] = item;
        }
    }

    private void SelectElement(T item)
    {
        if (!SelectElements.Any(x => x.Equals(item)))
        {
            SelectElements.Add(item);
        }
        sampleItem = default(T);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WebApp.Shared.Commons.MultiSelectorTypeahead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TItem __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::WebApp.Shared.Commons.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
