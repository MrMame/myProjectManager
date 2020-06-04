using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using myProjectManager.Model;
using myProjectManager.Views;

namespace myProjectManager.Controller
{
    public class ContentController
    {
        private IContentView _theView;
        private ProjectsModel _theModel;


        #region "FactoryMethods"
        public static ContentController GetContentCrontroller()
            {
                return new ContentController();
            }
            public static ContentController GetContentCrontroller(IContentView theView, ProjectsModel theModel)
            {
            return new ContentController(theView,theModel);
        }
        #endregion

        #region "Private Constructors"
        private ContentController()
        {
        }
        public ContentController(IContentView theView, ProjectsModel theModel)
        {
            this._theView = theView;
            this._theModel = theModel;
        }

        #endregion


        public ProjectsModel GetModel(){
            return this._theModel;
        }
        public IContentView GetView() {
            return this._theView;
        }

        public void AddProject(Project item)
        {
            this._theModel.AddProject(item);
        }

    }
}
