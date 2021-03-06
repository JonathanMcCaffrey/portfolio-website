using System;
using System.Collections.Generic;

namespace DPW.Data.Resume
{
    public class Resume
    {
        public Title Title { get; set; }
        public List<PersonalInfo> PersonalInfo { get; set; }
        public List<Experience> Experience { get; set; }
        public List<Reference> References { get; set; }
        public List<string> Skills { get; set; }
        public string Summary { get; set; }
        public List<string> Education { get; set; }
        public List<Project> Projects { get; set; }
        public List<SideProjects> SideProjects { get; set; }
    }
}
