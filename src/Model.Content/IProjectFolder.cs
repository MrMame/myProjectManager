using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public interface IProjectFolder
    {
        string ProjectFolderName { get; set; }
        IProject ParentProject { get; set; }
        IPicture Symbol { get; set; }
    }
}
