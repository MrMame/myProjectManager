using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace myProjectManager.Model
{
    public class ProjectsModel
    {

        List<Project> _Projects;



        public ReadOnlyCollection<Project> ReadOnlyCollectionOfProjects => this._Projects.AsReadOnly();


        #region "Factory Methods"
            public static ProjectsModel GetContentModel()
            {
                return new ProjectsModel();
            }
        #endregion


        #region "Private Constructors"
        private ProjectsModel(){
        this._Projects = new List<Project>();
        }

        internal void AddProject(Project item){
            this._Projects.Add(item);
        }
        #endregion

    }
}
