#pragma checksum "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16c0e1b052c1883e539e459e3cac0abec0da0ba"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using DemoProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jalil\source\repos\Blazor\practical-asp\DemoProject\_Imports.razor"
using DemoProject.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, World!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<DemoProject.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
