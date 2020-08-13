using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace Website.Pages.Resume
{
    public partial class Resume : ComponentBase
    {

        private Data.Resume.Resume ResumeData {get;set;} 

        [Inject]
        protected HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ResumeData = await Http.GetJsonAsync<Data.Resume.Resume>("json/resume/data.json" );
        }
    }
}