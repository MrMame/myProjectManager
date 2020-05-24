using NUnit.Framework;
using myProjectManager.Model.Content;

namespace Model.Content
{
    public class SubFile_Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateReference()
        {
            SubFile theSubfile = SubFile.GetSubFile();
            Assert.IsNotNull(theSubfile, "Error create Blank instance");
        }
        [Test]
        public void CreateFullReference()
        {
            string DisplayName = "The Subfile";
            string Description = "The Description";
            ProjectFolder ParentFolder = ProjectFolder.GetProjectFolder();

            SubFile theSubfile = SubFile.GetSubFile(DisplayName,Description,ParentFolder);

            Assert.AreEqual(DisplayName,theSubfile.DisplayName, "Displayname is not the same");
            Assert.AreEqual(Description, theSubfile.Description, "Description is not the same");
            Assert.AreEqual(ParentFolder, (ProjectFolder)theSubfile.ParentFolder, "ParentFolder is not the same");
        }



    }
}