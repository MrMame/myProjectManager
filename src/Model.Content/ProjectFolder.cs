using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public class ProjectFolder : IProjectFolder, IContentFolder, IContent
    {
        
        #region "IProjectFolder"
        public string ProjectFolderName { get; set; }
        public IProject ParentProject { get; set; }
        #endregion

        #region "IContentFolder"
        public List<IContent> Contents { get; set; }
        #endregion

        #region "IContent"
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public IContentFolder ParentFolder { get; set; }
        #endregion


        #region "FactoryMethods"
        public static ProjectFolder GetProjectFolder()
        {
            return new ProjectFolder();
        }
        public static ProjectFolder GetProjectFolder(string Name, IProject ParentProject)
        {
            return new ProjectFolder(Name, ParentProject);
        }
        public static ProjectFolder GetProjectFolder(string Name, IProject ParentProject, string DisplayName, string Description, IContentFolder ParentFolder)
        {
            return new ProjectFolder(Name, ParentProject, DisplayName, Description, ParentFolder);
        }
        #endregion

        #region "Private Constructors"
        private ProjectFolder()
        {

            this.ProjectFolderName = "";
            this.ParentProject = null;

            this.Contents = new List<IContent>();

            this.DisplayName = "";
            this.Description = "";
            this.ParentFolder = null;
        }
        private ProjectFolder(string Name, IProject ParentProject)
        {
            this.ProjectFolderName = Name;
            this.ParentProject = ParentProject;

            this.Contents = new List<IContent>();

            this.DisplayName = "";
            this.Description = "";
            this.ParentFolder = null;
        }
        private ProjectFolder(string Name, IProject ParentProject, string DisplayName, string Description, IContentFolder ParentFolder)
        {
            this.ProjectFolderName = Name;
            this.ParentProject = ParentProject;

            this.Contents = new List<IContent>();

            this.DisplayName = DisplayName;
            this.Description = Description;
            this.ParentFolder = ParentFolder;
        }
        #endregion
    }
}
