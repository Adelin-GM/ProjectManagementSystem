#pragma checksum "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0efb3a9c1a278fab4ad5a70b88fece2cce9bef5"
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
#line 5 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets/read")]
    public partial class Read : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-white mb-3 col-md-8 offset-md-2");
            __builder.AddAttribute(2, "style", "max-width:" + " 25rem;" + " max-width:" + " 25rem;" + " background-image:" + " linear-gradient(" + " to" + " right," + " " + (
#nullable restore
#line 10 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                                                                                                cardBackground

#line default
#line hidden
#nullable disable
            ) + " );");
#nullable restore
#line 11 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
     if (showEdit)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagement.Client.Pages.Tickets.Edit>(3);
            __builder.AddAttribute(4, "ticket", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjectManagement.Shared.Ticket>(
#nullable restore
#line 13 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                      ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnEdited", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Guid>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Guid>(this, 
#nullable restore
#line 13 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                        UpdateEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
    }
    else if (showAddUser)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagement.Client.Pages.Tickets.AddUser>(6);
            __builder.AddAttribute(7, "OnEdited", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Guid>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Guid>(this, 
#nullable restore
#line 17 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                           UpdateEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ticket", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjectManagement.Shared.Ticket>(
#nullable restore
#line 17 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                               ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 18 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
    }
    else if (showDetails)
    { 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagement.Client.Pages.Tickets.ReadUsers>(9);
            __builder.AddAttribute(10, "OnEdited", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Guid>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Guid>(this, 
#nullable restore
#line 21 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                             UpdateEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "userTickets", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjectManagement.Shared.UserTicket[]>(
#nullable restore
#line 21 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                      userTickets

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ticket", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjectManagement.Shared.Ticket>(
#nullable restore
#line 21 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                           ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 22 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-header d-flex justify-content-between");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "p-2");
#nullable restore
#line 27 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                 if (ticket.State != "Todo")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "style", "cursor: pointer");
            __builder.AddAttribute(19, "class", "oi oi-caret-left float-right m-2 text-light");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                                                             ChangeToLeftState

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n            ");
            __builder.OpenElement(22, "h4");
            __builder.AddContent(23, 
#nullable restore
#line 33 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                 ticket.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "p-2");
#nullable restore
#line 35 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                 if (ticket.State != "Done")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "style", "cursor: pointer");
            __builder.AddAttribute(29, "class", "oi oi-caret-right float-right m-2 text-light");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                                                              ChangeToRightState

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-body");
            __builder.AddMarkupContent(34, "<h5 class=\"card-title\">Description</h5>\r\n            ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text");
            __builder.AddContent(37, 
#nullable restore
#line 44 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                  ticket.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card-footer");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(43, "<div class=\"p-2\"></div>\r\n                <div class=\"p-2\"></div>\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "p-2");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "style", "cursor: pointer");
            __builder.AddAttribute(48, "class", "oi oi-trash float-right m-2 text-danger");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                                                         DeleteTicket

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "             \r\n                    ");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "style", "cursor: pointer");
            __builder.AddAttribute(53, "class", "oi oi-pencil float-right m-2 text-primary");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                                                           ShowEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "               \r\n                    ");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "style", "cursor: pointer");
            __builder.AddAttribute(58, "class", "oi oi-info float-right m-2 text-light");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                                                       ShowDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "                \r\n                    ");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "style", "cursor: pointer");
            __builder.AddAttribute(63, "class", "oi oi-plus float-right m-2 text-success");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
                                                                                                         ShowAddUsers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Tickets\Read.razor"
       
    [Parameter]
    public Ticket ticket { get; set; }
    [Parameter]
    public string cardBackground { get; set; }
    bool showEdit;
    bool showDetails;
    bool showAddUser;
    UserTicket[] userTickets;

    [Parameter]
    public EventCallback<Guid> OnChanged { get; set; }


    protected override async void OnInitialized()
    {
        SetCardBackground();
        await UpdateUserTickets();

    }

    public async Task UpdateUserTickets()
    {
        try
        {
            userTickets = await Http.GetFromJsonAsync<UserTicket[]>($"/api/UserTicket/{ticket.Id}");
        }
        catch (Exception)
        {
        }
    }

    private void SetCardBackground()
    {
        if (ticket.State == "Done")
            cardBackground = "#000, #159957";                     //green
        else if (ticket.State == "Progress")
            cardBackground = "#000, #005AA7";                     //blue
        else
            cardBackground = "#000, #b20a2c";                     //black
    }

    public void ShowEdit()
    {
        if (showEdit == true)
        {
            showEdit = false;
        }
        else
        {
            showDetails = false;
            showAddUser = false;
            showEdit = true;
        }
    }

    private void ShowDetails()
    {
        if (showDetails == true)
        {
            showDetails = false;
        }
        else
        {
            showEdit = false;
            showAddUser = false;
            showDetails = true;
        }
    }

    private void ShowAddUsers()
    {
        if (showAddUser == true)
        {
            showAddUser = false;
        }
        else
        {
            showDetails = false;
            showEdit = false;
            showAddUser = true;
        }
    }





    public async Task UpdateEdit()
    {
        await UpdateUserTickets();
        ticket = await Http.GetFromJsonAsync<Ticket>($"/api/Tickets/{ticket.Id}");
        showDetails = false;
        showAddUser = false;
        showEdit = false;
    }

    private async void DeleteTicket()
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {ticket.Name}?");
        if (!confirmed)
            return;


        await Http.DeleteAsync($"/api/Tickets/{ticket.Id}");
        await OnChanged.InvokeAsync(ticket.Id);
    }




    private async void ChangeToRightState()
    {
        foreach (var userTicket in userTickets)         //log user progress
        {
            if (ticket.State == "Todo")
            {
                userTicket.StartedDate = DateTime.Now;
                await UpdateUserTicketInDatabase(userTicket);
            }
            else if (ticket.State == "Progress")
            {
                userTicket.FinishedDate = DateTime.Now;
                await UpdateUserTicketInDatabase(userTicket);
            }
        }

        if (ticket.State == "Todo")
        {
            ticket.State = "Progress";
        }
        else if(ticket.State == "Progress")
        {
            ticket.State = "Done";
        }
        await UpdateTicket();

    }

    private async void ChangeToLeftState()
    {
        foreach (var userTicket in userTickets)         //change user progress logs
        {
            if (ticket.State == "Done")
            {
                userTicket.FinishedDate = new DateTime();   //in the ticket is moved back the finish date will be removed
                await UpdateUserTicketInDatabase(userTicket);
            }
            else if (ticket.State == "Progress")
            {
                userTicket.StartedDate = new DateTime();   //in the ticket is moved back the started date will be removed
                await UpdateUserTicketInDatabase(userTicket);
            }
        }

        if (ticket.State == "Done")
        {
            ticket.State = "Progress";
        }
        else if (ticket.State == "Progress")
        {
            ticket.State = "Todo";
        }
        await UpdateTicket();
    }

    private async Task UpdateTicket()
    {
        try
        {
            var response = await Http.PutAsJsonAsync($"/api/Tickets/{ticket.Id}", ticket);
            response.EnsureSuccessStatusCode();

            await OnChanged.InvokeAsync(ticket.Id);
        }
        catch (Exception e)
        {
        }
    }

    private async Task UpdateUserTicketInDatabase(UserTicket ut)
    {
        try
        {
            var response = await Http.PutAsJsonAsync($"/api/UserTicket/{ut.Id}", ut);
            response.EnsureSuccessStatusCode();
        }
        catch (Exception e)
        {
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
