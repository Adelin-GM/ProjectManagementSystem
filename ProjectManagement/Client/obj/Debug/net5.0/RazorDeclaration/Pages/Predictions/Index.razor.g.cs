// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectManagement.Client.Pages.Predictions
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
#line 6 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Predictions\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/predictions")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\adeli\OneDrive\Desktop\Uni\Year 2\Enterprise Application Development\EADCW\ProjectManagementBackup12\ProjectManagement\Client\Pages\Predictions\Index.razor"
       
    string today = DateTime.Today.ToString("yyyy-MM-dd");
    public DateTime SelectedDate { get; set; } = DateTime.Today;
    public Company SelectedCompany { get; set; } = new Company();
    Company[] companies;
    Project[] projects;
    List<Project> ProjectHistory { get; set; } = new List<Project>();
    int userCount;
    int averageUsers;

    protected override async Task OnInitializedAsync()
    {
        await GetCompanies();
    }

    private async Task GetCompanies()
    {
        companies = await Http.GetFromJsonAsync<Company[]>("api/Companies");
    }

    private async Task GetProjects()
    {
        try
        {
            projects = await Http.GetFromJsonAsync<Project[]>($"/api/projects/company/{SelectedCompany.Id}");
        }
        catch (Exception e)
        {
        }
    }

    private void SelectProjectsWhichIncludeSelectedMonth()
    {
        ProjectHistory = new List<Project>();
        if (projects != null)
        {
            foreach (var project in projects)
            {
                if (project.StartDate.Year == project.DueDate.Year)
                {
                    if (SelectedDate.Month >= project.StartDate.Month && SelectedDate.Month <= project.DueDate.Month)
                    {
                        ProjectHistory.Add(project);
                    }
                }
                else
                {
                    if (SelectedDate.Month >= project.StartDate.Month)
                    {
                        ProjectHistory.Add(project);
                    }
                    else if (SelectedDate.Month <= project.DueDate.Month)
                    {
                        ProjectHistory.Add(project);
                    }
                }
            }
        }
    }

    private async Task getAverageUsers()
    {
        if (ProjectHistory.Any())
        {
            foreach (var project in ProjectHistory)
            {

                List<UserProject> userProjects = await Http.GetFromJsonAsync<List<UserProject>>($"/api/UserProjects/{project.Id}");
                userCount += userProjects.Count;

            }
        }
        else
        {
            await JsRuntime.InvokeVoidAsync("alert", "Not enought data to make a prediction for selected month"); // Alert
            ClearProjectHistoryList();
            return;
        }
        averageUsers = userCount / ProjectHistory.Count;
    }





    private async Task MakePrediction()
    {
        await GetProjects();
        userCount = 0;
        if (projects.Length == 0)
        {
            await JsRuntime.InvokeVoidAsync("alert", "An error occurred, no project history found for this company"); // Alert
            return;
        }
        SelectProjectsWhichIncludeSelectedMonth();
        await getAverageUsers();

    }


    private void ClearProjectHistoryList()
    {
        ProjectHistory = new List<Project>();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
