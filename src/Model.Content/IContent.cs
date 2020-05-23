using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public interface IContent
    {
        string DisplayName { get; set; }
        string Description { get; set; }
        IContentFolder ParentFolder { get; set; }

    }
}
