using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProjectManager.Views
{
    public interface IContentView
    {

        void AddProject();
        void RemoveProject();
        void SelectProject();


        void CreateFolder();
        void RemoveFolder();
        void SelectFolder();


        void CreateFile();
        void RemoveFile();
        void SelectFile();



    }
}
