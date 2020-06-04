using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
{
    public interface IProject
    {
        string ProjectName { get; set; }
        IPicture Symbol { get; set; }
    }
}
