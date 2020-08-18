using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace DPW.Pages.About
{
    public partial class About : ComponentBase
    {
        protected AboutData AboutData { get; set; }

        [Inject]
        protected HttpClient Http { get; set; }


        [Parameter]
        public string MarkdownFileName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AboutData = await Http.GetJsonAsync<AboutData>("json/about/data.json");
        }
    }
}
