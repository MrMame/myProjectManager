using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public class SubFile : IContent, ITagged
    {
        #region "IContent"
            public string DisplayName { get; set; }
            public string Description { get; set; }
            public IContentFolder ParentFolder { get; set; }
        #endregion

        #region "FactoryMethods"
        public static SubFile GetSubFile() { return new SubFile(); }
            public static SubFile GetSubFile(string DisplayName, string Description, IContentFolder ParentFolder)
            {
                return new SubFile(DisplayName, Description, ParentFolder);
            }
        #endregion

        #region "ITagged"
        public List<Tag> Tags { get; set; }
        #endregion



        #region "PrivateConstructors"
        private SubFile()
            {
                this.DisplayName = "";
                this.Description = "";
                this.ParentFolder = null;
                this.Tags = new List<Tag>();    
            }
            private SubFile(string DisplayName, string Description, IContentFolder ParentFolder)
            {
                this.DisplayName = DisplayName;
                this.Description = Description;
                this.ParentFolder = ParentFolder;
                this.Tags = new List<Tag>();
            }
        #endregion


    }
}
