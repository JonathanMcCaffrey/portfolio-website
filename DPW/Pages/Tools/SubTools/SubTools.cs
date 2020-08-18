using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace DPW.Pages.Tools.SubTools
{
    public partial class SubTools : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        protected ToolsData ToolsData { get; set; }

        [Inject]
        protected HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ToolsData = await Http.GetJsonAsync<ToolsData>("json/tools/data.json");
        }
    }
}