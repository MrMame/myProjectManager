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
        [Test]
        public void AddPictureToProject()
        {
            string Filename = "c:\\temp.jpg";
            Picture theSymbol = Picture.GetPicture(Filename);

            string ProjectName = "The Project Name";
            Project theProject = Project.GetProject(ProjectName);
            theProject.Symbol = theSymbol;


            Assert.AreEqual(Filename, theProject.Symbol.PictureFilename, "Filename for Symbol is not the right one.");
        }
        [Test]
        public void AddTagsToProject()
        {
            string ProjectName = "The Project Name";
            Project theProject = Project.GetProject(ProjectName);

            string TagStringImportant = "Important";
            Tag theTag = Tag.GetTag(TagStringImportant);
            string TagStringNew = "New";
            Tag theNewTag = Tag.GetTag(TagStringNew);

            theProject.Tags.Add(theTag);
            theProject.Tags.Add(theNewTag);

            Assert.AreEqual(TagStringImportant, ((Tag)theProject.Tags[0]).TagString, "Tag is not the same.");
            Assert.AreEqual(TagStringNew, ((Tag)theProject.Tags[1]).TagString, "Tag is not the same.");
        }


    }
}