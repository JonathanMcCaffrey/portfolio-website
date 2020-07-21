using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;


namespace Website.Pages.About
{
    public class AboutBase : ComponentBase
    {


        protected AboutData About {get; set;}



        [Inject]
        protected HttpClient Http { get; set; }


        [Parameter]
        public string MarkdownFileName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            About = await Http.GetJsonAsync<AboutData>("json/about/data.json" );
        }

    }
}


//Cannot implicitly convert type 'System.Threading.Tasks.Task<System.Collections.Generic>' to 'System.Collections.Generic.List<>'