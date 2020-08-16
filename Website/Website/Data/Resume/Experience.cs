using System;
using System.Collections.Generic;

namespace Website.Data.Resume
{
    public class Experience
    {
        public string Date { get; set; }
        public string Location { get; set; }

        public string Role { get; set; }

        public List<string> Points { get; set; }
    }
}