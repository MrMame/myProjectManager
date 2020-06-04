using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
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
            public static SubFile GetSubFile(string DisplayName, string Description)
            {
                return new SubFile(DisplayName, Description);
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
            private SubFile(string DisplayName, string Description)
            {
                this.DisplayName = DisplayName;
                this.Description = Description;
                this.ParentFolder = null;
                this.Tags = new List<Tag>();
            }
        #endregion
    }
}
