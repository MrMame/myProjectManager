using NUnit.Framework;
using myProjectManager.Model.Content;

namespace Model.Content
{
    public class SubFolder_Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateReference()
        {
            SubFolder theSubFolder = SubFolder.GetSubFolder();
            Assert.IsNotNull(theSubFolder, "Couldnt Create Instance");
        }

        [Test]
        public void CreateFullReference()
        {
            string DisplayName = "The Display Name";
            string Description = "The Description";
            ProjectFolder ParentFolder = ProjectFolder.GetProjectFolder();

            SubFolder theSubFolder = SubFolder.GetSubFolder(DisplayName,Description,ParentFolder);

            Assert.AreEqual(DisplayName,theSubFolder.DisplayName, "Displayname is not the same");
            Assert.AreEqual(Description, theSubFolder.Description, "Description is not the same");
            Assert.AreEqual(ParentFolder, (ProjectFolder)theSubFolder.ParentFolder, "ProjectFolder is not the same");
        }



    }
}