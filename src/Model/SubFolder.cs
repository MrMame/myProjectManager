using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
{
    public class SubFolder : IContentFolder, IContent, ITagged
    {

        List<IContent> _Contents = null;



        #region "IContentFolder"
        public ReadOnlyCollection<IContent> ReadOnlyContentsList => this._Contents.AsReadOnly();
        public void AddContent(IContent item){
            item.ParentFolder = this;
            this._Contents.Add(item);
        }
        public void RemoveContent(IContent item){
            this._Contents.Remove(item);
        }
        #endregion


        #region "IContent"
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public IContentFolder ParentFolder { get; set; }
        #endregion

        #region "ITagged"
        public List<Tag> Tags { get; set; }

        #endregion

        #region "FactoryMethods"
        public static SubFolder GetSubFolder() { return new SubFolder(); }
        public static SubFolder GetSubFolder(string DisplayName, string Description){
            return new SubFolder(DisplayName, Description);
        }
        #endregion

        #region "Private Constructors"
        private SubFolder(){
            this.DisplayName = "";
            this.Description = "";
            this.ParentFolder = null;
            this._Contents = new List<IContent>();
            this.Tags = new List<Tag>();
        }
        private SubFolder(string DisplayName, string Description){
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.ParentFolder = null;
            this._Contents = new List<IContent>();
            this.Tags = new List<Tag>();
        }
        #endregion


    }
}
