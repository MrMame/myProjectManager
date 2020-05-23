using NUnit.Framework;
using myProjectManager.Controller;
using myProjectManager.Model.Content;
using System.IO;

namespace Controller
{
    public class AccessController
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateReference()
        {
            myProjectManager.Controller.AccessController theAccesController = new AccessController();
            Assert.IsNotNull(theAccesController, "Instance Error : Couldn't create instance of AccessController Class.");
        }

   

        [Test]
        public void WriteEmptyProjectToFileSystem()
        {
            // Delete target Directory if it's already existing
            string TargetPath = "C:\\Temp";
            DirectoryInfo TargetDir = new DirectoryInfo(TargetPath);
            if (TargetDir.Exists) { TargetDir.Delete(true); }

            // Create Project to store
            string ProjectName = "The Project";
            Project theProject = new Project(ProjectName);
            // Create Access Controller and let it write the Project to the Filesystem
            AccessController theAccessController = new AccessController();
            theAccessController.WriteProjectToFileSystem(theProject, TargetDir);

            // Check if Target Folder is now existing
            Assert.IsTrue(TargetDir.Exists, "Target Folder was not created while trying to store the Project to Filesystem.");
        }
    }
}