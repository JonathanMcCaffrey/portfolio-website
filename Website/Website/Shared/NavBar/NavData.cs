using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Website.Shared.NavBar
{
    public class SectionData
    {
        public string Name {get;set;}
        public string Href { get; set; }
    }

    public class SocialMediaData
    {
        public string Name {get;set;}
        public string Icon { get; set; }
        public string Href { get; set; }
    }

    public class NavData
    {
        public string BrandTitle {get;set;}

        public List<SectionData> Sections { get; set; }

        public List<SocialMediaData> SocialMedia { get; set; }
    }
}
