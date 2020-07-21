using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;

namespace Website.Pages.Tools.SubTools
{
    public class SubToolsBase : ComponentBase
    {
     [Parameter]
    public string Id { get; set; }

    protected ToolsData ToolsData {get; set;}

        [Inject]
        protected HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ToolsData = await Http.GetJsonAsync<ToolsData>("json/tools/data.json");
        }
    }
}