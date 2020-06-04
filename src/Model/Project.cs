using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
{
    public class Project : IProject, IContentFolder, ITagged
    {
        List<IContent> _Contents;


        #region "IProject"
        public string ProjectName { get; set; }
            public IPicture Symbol { get; set; }
        #endregion

        #region "IContentFolder"
        public ReadOnlyCollection<IContent> ReadOnlyContentsList => this._Contents.AsReadOnly();
        public void AddContent(IContent item){
            this._Contents.Add(item);
            item.ParentFolder = this;
        }

        public void RemoveContent(IContent item){
            this._Contents.Remove(item);
        }
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
            this._Contents = new List<IContent>();
            this.Tags = new List<Tag>();
        }
        private Project(string ProjectName)
        {
            this.ProjectName = ProjectName;
            this._Contents = new List<IContent>();
            this.Tags = new List<Tag>();
        }
        #endregion


    }
}
