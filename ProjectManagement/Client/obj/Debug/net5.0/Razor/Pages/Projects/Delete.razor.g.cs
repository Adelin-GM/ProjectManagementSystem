#pragma checksum "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Projects\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363b881203375b33c5b506aed03827abd121ab84"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagement.Client.Pages.Projects
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using ProjectManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using ProjectManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using ProjectManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Projects\Delete.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects/delete/{Id:guid}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Are you sure you want to delete ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Projects\Delete.razor"
                                         Project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, "?");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "btn-group");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btm btn-danger ml-5");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Projects\Delete.razor"
                                                      DeleteCompany

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btm btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Projects\Delete.razor"
                                                  CancelDelete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Projects\Delete.razor"
       

    [Parameter]
    public Guid Id { get; set; }
    public Project Project { get; set; } = new Project();

    protected async override Task OnInitializedAsync()
    {
        try
        {
            Project = await Http.GetFromJsonAsync<Project>($"/api/projects/{Id}");
        }
        catch (Exception e)
        {
        }
    }

    private async void DeleteCompany()
    {
        await Http.DeleteAsync($"/api/projects/{Id}");
        Navigation.NavigateTo("/companies");
    }

    private void CancelDelete()
    {
        Navigation.NavigateTo("/companies");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
