using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace DPW.Pages.About
{
    public class AboutData
    {
        public string Title {get;set;}
        public string Lead {get;set;}
        public string Body {get;set;}
        public LearnMoreData LearnMoreData { get;set;}
    }
}
