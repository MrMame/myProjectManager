using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myProjectManager.Views;

namespace myProjectManager.Views
{
    public partial class MainView : Form, IContentView
    {
        public MainView()
        {
            InitializeComponent();
        }
        
        #region "IContentView"
            public void AddProject()
            {
                throw new NotImplementedException();
            }

            public void CreateFile()
            {
                throw new NotImplementedException();
            }

            public void CreateFolder()
            {
                throw new NotImplementedException();
            }

            public void RemoveFile()
            {
                throw new NotImplementedException();
            }

            public void RemoveFolder()
            {
                throw new NotImplementedException();
            }

            public void RemoveProject()
            {
                throw new NotImplementedException();
            }

            public void SelectFile()
            {
                throw new NotImplementedException();
            }

            public void SelectFolder()
            {
                throw new NotImplementedException();
            }

            public void SelectProject()
            {
                throw new NotImplementedException();
            }
        #endregion




    }
}
