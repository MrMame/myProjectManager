using NUnit.Framework;
using myProjectManager.Model.Content;



namespace Model.Content
{
    public class Project_Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateBlankReference()
        {
            Project theProject = Project.GetProject();
            Assert.IsNotNull(theProject, "Couldn receive Project Class Object");
        }
        [Test]
        public void CreateReference()
        {
            string ProjectName = "The Project Name";
            Project theProject = Project.GetProject(ProjectName);
            Assert.AreEqual(ProjectName, theProject.ProjectName, "Couldn receive Project Class Object");
        }
        [Test]
        public void AddContentToProject()
        {
            string ProjectName = "The Project Name";
            Project theProject = Project.GetProject(ProjectName);

            ProjectFolder EmailFolder = ProjectFolder.GetProjectFolder("EMAILS", theProject);
            ProjectFolder BillsFolder = ProjectFolder.GetProjectFolder("BILLS", theProject);

            theProject.Contents.Add(EmailFolder);
            theProject.Contents.Add(BillsFolder);

            Assert.AreEqual((ProjectFolder)theProject.Contents[0],EmailFolder,"EMAIL ProjectFolder is not inside the List");
            Assert.AreEqual((ProjectFolder)theProject.Contents[1], BillsFolder, "BILL ProjectFolder is not inside the List");

        }

        public void AddPictureToProject()
        {
            string ProjectName = "The Project Name";
            Project theProject = Project.GetProject(ProjectName);

            string Filename = "c:\\temp.jpg";
            Picture theSymbol = Picture.GetPicture(Filename);

            Assert.AreEqual(Filename, theProject.Symbol.PictureFilename, "Filename for Symbol is not the right one.");
        }


    }
}