using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model.Content
{
    public interface IProject
    {
        string ProjectName { get; set; }
        IPicture Symbol { get; set; }
    }
}
