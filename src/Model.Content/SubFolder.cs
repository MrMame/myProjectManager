using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public class SubFolder : IContentFolder, IContent
    {
        #region "IContentFolder"
            public List<IContent> Contents { get; set; }
        #endregion
        
        
        #region "IContent"
            public string DisplayName { get; set; }
            public string Description { get; set; }
            public IContentFolder ParentFolder { get; set; }
        #endregion


        #region "FactoryMethods"
            public static SubFolder GetSubFolder() { return new SubFolder(); }
            public static SubFolder GetSubFolder(string DisplayName, string Description, IContentFolder ParentFolder)
            {
                return new SubFolder(DisplayName, Description, ParentFolder);
            }
        #endregion

        #region "Private Constructors"
            private SubFolder()
            {
            this.DisplayName = "";
            this.Description = "";
            this.ParentFolder = null;
            this.Contents = new List<IContent>();
            }
            private SubFolder(string DisplayName, string Description, IContentFolder ParentFolder)
            {
                this.DisplayName = DisplayName;
                this.Description = Description;
                this.ParentFolder = ParentFolder;
                this.Contents = new List<IContent>();
            }
        #endregion


    }
}
