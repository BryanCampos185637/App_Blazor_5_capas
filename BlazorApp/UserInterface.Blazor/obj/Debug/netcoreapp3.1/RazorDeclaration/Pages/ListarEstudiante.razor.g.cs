// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UserInterface.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using UserInterface.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\_Imports.razor"
using UserInterface.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\Pages\ListarEstudiante.razor"
using BussinesLogic.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\Pages\ListarEstudiante.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listaEstudiante")]
    public partial class ListarEstudiante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Bryan J. Campos\source\repos\BlazorApp\UserInterface.Blazor\Pages\ListarEstudiante.razor"
       
    private List<Student> lista;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            lista = await bl.Listar();
        }
        catch (Exception)
        {
            lista = null;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentBL bl { get; set; }
    }
}
#pragma warning restore 1591
