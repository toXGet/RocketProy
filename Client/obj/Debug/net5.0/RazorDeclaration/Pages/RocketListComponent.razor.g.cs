// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RocketProy.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using RocketProy.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using RocketProy.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using RocketProy.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/saint/Documentos/RocketProy/Client/_Imports.razor"
using RocketProy.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class RocketListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/home/saint/Documentos/RocketProy/Client/Pages/RocketListComponent.razor"
       
  public List<Rocket> Rockets;
  private List<Rocket> GetRocket()
  {
    return new List<Rocket>(){
      new Rocket(){RocketName = "Long March", RocketDescription = "Diseñado especialmente para cargas pesadas", RocketImage = "/Images/Cohete-LongMarch.jpg"},
      new Rocket(){RocketName = "Proton M", RocketDescription = "Potente lanzador sin tripulación Ruso", RocketImage = "/Images/Cohete-Proton.jpg"},
      new Rocket(){RocketName = "Hayabusa", RocketDescription = "Parte del desarollo espacial Japonés", RocketImage = "/Images/Cohete-Hayabusa.jpg"},
    };
  }
  protected override async Task OnInitializedAsync()
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/home/saint/Documentos/RocketProy/Client/Pages/RocketListComponent.razor"
                                                                     
    await Task.Delay(3000);
    Rockets = GetRocket();
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
