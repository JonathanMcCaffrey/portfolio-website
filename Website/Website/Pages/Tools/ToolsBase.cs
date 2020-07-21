using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Website.Pages.Tools.SubTools;

namespace Website.Pages.Tools
{
    public class ToolsBase : ComponentBase
    {
        protected ToolsData ToolsData {get; set;}

        [Inject]
        protected HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ToolsData = await Http.GetJsonAsync<ToolsData>("json/tools/data.json");
        }
    }
}