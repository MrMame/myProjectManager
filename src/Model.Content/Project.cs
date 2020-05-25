using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public class Project : IProject, IContentFolder, ITagged
    {
        #region "IProject"
        public string ProjectName { get; set; }
        public IPicture Symbol { get; set; }
        #endregion

        #region "IContentFolder"
        public List<IContent> Contents { get; set; }
        #endregion

        #region "ITagged"
        public List<Tag> Tags { get; set; }
        #endregion




        #region "FactoryMethods"
        public static Project GetProject() { return new Project(); }
        public static Project GetProject(string ProjectName) { return new Project(ProjectName); }
        #endregion


        #region "Private Constructors"
        private Project()
        {
            this.ProjectName = "";
            this.Contents = new List<IContent>();
            this.Tags = new List<Tag>();
        }
        private Project(string ProjectName)
        {
            this.ProjectName = ProjectName;
            this.Contents = new List<IContent>();
            this.Tags = new List<Tag>();
        }
        #endregion


    }
}
