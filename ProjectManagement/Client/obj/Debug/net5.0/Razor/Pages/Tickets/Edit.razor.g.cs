#pragma checksum "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506c1cf1040980f3f6df889e7733279b0067bcd0"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagement.Client.Pages.Tickets
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
#line 5 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets/edit")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
                 ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, " \r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card-header");
                __builder2.OpenElement(8, "h4");
                __builder2.AddContent(9, 
#nullable restore
#line 10 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
             ticket.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
                            ticket.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.Name = __value, ticket.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __Blazor.ProjectManagement.Client.Pages.Tickets.Edit.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 12 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
                                  () => ticket.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "card-body");
                __builder2.AddMarkupContent(20, "<h5 class=\"card-title\">Description</h5>\r\n        ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
                            ticket.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.Description = __value, ticket.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.AddMarkupContent(25, "<div class=\"card-footer\"><div><button type=\"submit\" class=\"btn btn-sm btn-outline-light m-2\">Submit</button></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Edit.razor"
       
    [Parameter]
    public Ticket ticket { get; set; }
    [Parameter]
    public EventCallback<Guid> OnEdited { get; set; }


    private async void HandleValidSubmit()
    {
        try
        {
            var response = await Http.PutAsJsonAsync($"/api/Tickets/{ticket.Id}", ticket);
            response.EnsureSuccessStatusCode();

            await OnEdited.InvokeAsync(ticket.Id);
        }
        catch (Exception e)
        {
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.ProjectManagement.Client.Pages.Tickets.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591