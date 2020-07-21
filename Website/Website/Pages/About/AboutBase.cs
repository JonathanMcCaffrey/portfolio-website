using System;
using Microsoft.JSInterop;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Website.Pages.About
{
    public class AboutBase : ComponentBase
    {

        protected AboutData AboutData {get; set;}


        [Inject]
        protected HttpClient Http { get; set; }


        [Parameter]
        public string MarkdownFileName { get; set; }

        protected override async Task OnInitializedAsync()
        {




            AboutData = Http.GetJsonAsync<AboutData>(await Http.GetStringAsync($"content/about/json/data.json"));

        }

    }
}
