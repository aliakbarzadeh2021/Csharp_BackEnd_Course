// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Csharp_BackEnd_Course.ASPNet.ToDoBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\_Imports.razor"
using ToDoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\_Imports.razor"
using ToDoBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "G:\SVN\Backend Course\Main Source\Csharp_BackEnd_Course\Csharp_BackEnd_Course.ASPNet.ToDoBlazor\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
