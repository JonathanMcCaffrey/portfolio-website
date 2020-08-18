using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DPW.Pages.Tools.SubTools;

namespace DPW.Pages.Tools
{
    public partial class Tools : ComponentBase
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