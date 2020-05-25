using NUnit.Framework;
using myProjectManager.Model.Content;

namespace Model.Content
{
    public class ProjectFolder_Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateReference()
        {
            ProjectFolder theProjectFolder = ProjectFolder.GetProjectFolder();
            Assert.IsNotNull(theProjectFolder, "Instance was not received");
        }

        [Test]
        public void CreateFullReference()
        {
            string ProjectFolderName = "The Folder";
            Project ParentProject = Project.GetProject("TheParentProject"); 
            string DisplayName = "Display Name";
            string Description = "Description TExt";
            ProjectFolder ParentFolder = ProjectFolder.GetProjectFolder("ParentFolder", ParentProject);

            ProjectFolder theProjectFolder = ProjectFolder.GetProjectFolder(ProjectFolderName, ParentProject, DisplayName, Description,ParentFolder);

            Assert.AreEqual(ProjectFolderName, theProjectFolder.ProjectFolderName, "ProjectFolderName is not the same");
            Assert.AreEqual(ParentProject, (Project)theProjectFolder.ParentProject, "Project is not the same");
            Assert.AreEqual(DisplayName, theProjectFolder.DisplayName, "Displayname is not the same");
            Assert.AreEqual(Description, theProjectFolder.Description, "Description is not the same");
            Assert.AreEqual(ParentFolder, (ProjectFolder)theProjectFolder.ParentFolder, "ProjectFolder is not the same");

        }
        [Test]
        public void AddTagsTo()
        {

            ProjectFolder theProjectFolder = ProjectFolder.GetProjectFolder();

            string TagStringImportant = "Important";
            Tag theTag = Tag.GetTag(TagStringImportant);
            string TagStringNew = "New";
            Tag theNewTag = Tag.GetTag(TagStringNew);

            theProjectFolder.Tags.Add(theTag);
            theProjectFolder.Tags.Add(theNewTag);

            Assert.AreEqual(TagStringImportant, ((Tag)theProjectFolder.Tags[0]).TagString, "Tag is not the same.");
            Assert.AreEqual(TagStringNew, ((Tag)theProjectFolder.Tags[1]).TagString, "Tag is not the same.");
        }


    }
}