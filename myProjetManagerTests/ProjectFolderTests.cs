using NUnit.Framework;
using myProjectManager.Model.Content;
using System.IO;

namespace Model
{
    public class ProjectFolderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateReference()
        {
            ProjectFolder theProject = new ProjectFolder();
            Assert.IsNotNull(theProject, "Instance Error : Couldn't create instance of Class.");
        }

        [Test]
        public void CreateProjectWithNameAndDescription()
        {
            string TestDisplayName = "My Test Project";
            string TestDescriptionName = "Description of Testig Project file";


            ProjectFolder theProject = new ProjectFolder(TestDisplayName, TestDescriptionName,null);

            Assert.IsTrue(theProject.DisplayName == TestDisplayName , "Displayname of Project is not the same");
            Assert.IsTrue(theProject.Description == TestDescriptionName, "Displayname of Project is not the same");

        }

    
        [Test]
        public void AddProjectFolderToContentList()
        {

            ProjectFolder theProject = new ProjectFolder();
            theProject.DisplayName = "The Base Project";

            ProjectFolder theFolder = new ProjectFolder();

            theProject.Contents.Add(theFolder);

            Assert.IsTrue(theProject.Contents.Contains(theFolder), "Couldnt add another Folder to Source Projects ContentList");
        }


        [Test]
        public void CreateWithDirectoryInfo()
        {

            string TestDisplayName = "My Test Project";
            string TestDescriptionName = "Description of Testig Project file";
            string PathName = "C:\\";

            ProjectFolder theProject = new ProjectFolder(TestDisplayName, 
                                             TestDescriptionName,
                                             new DirectoryInfo(PathName));


            Assert.IsTrue(theProject.DirInfo.FullName.Equals(PathName), "Directoryinfo Pathname doesn't Match");
           
        }

    }
}