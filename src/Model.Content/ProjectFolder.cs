using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public class ProjectFolder : IContent, IPictured, ITagged, IFolder
    {
        public string DisplayName { get ; set; }
        public string Description { get ; set; }
        public List<IContent> Contents { get ; set ; }
        
        public DirectoryInfo DirInfo { get ; set ; }

        public ProjectFolder()
        {
  
            this.DisplayName = "";
            this.Description = "";
            this.Contents = new List<IContent>();
            this.DirInfo = null;
        }
        public ProjectFolder(string DisplayName,string Description,DirectoryInfo ProjectDirectoryinfo)
        {
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.Contents = new List<IContent>();
            this.DirInfo = ProjectDirectoryinfo;
        }

    }
}
