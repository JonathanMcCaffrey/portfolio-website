using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;

namespace Website.Pages.Tools.SubTools
{
    public class ToolData {
        public string Name {get; set;}
        public string Blurb {get; set;}
        public string Href {get; set;}
        public string Image {get; set;}

        public string ImageFullPath() { return $"images/pages/tools/{Image}.jpg"; }
        public string MarkdownFile {get; set;}
        
        public string MarkdownPath() { return $"tools/{MarkdownFile}"; }


        public string MarkdownLink() { return $"tools/{MarkdownFile}"; }
        
    }
    
    public class ToolsData
    {
        public List<ToolData> Tools {get; set;}
    }
}