﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Website.Components.MarkdownContent
{
    public class MarkdownContentBase : ComponentBase
    {
        [Inject]
        protected HttpClient Http { get; set; }

        [Parameter]
        public string MarkdownFileName { get; set; }

        public string Markdown { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Markdown = Markdig.Markdown.ToHtml(await Http.GetStringAsync($"markdown/{MarkdownFileName}.md"));
        }

    }
}
