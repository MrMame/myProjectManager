using NUnit.Framework;
using myProjectManager.Model.Content;

namespace Model
{
    public class ProjectTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateReference()
        {
            Project theProject = new Project();
            Assert.IsNotNull(theProject, "Instance Error : Couldn't create instance of Class.");
        }


    }
}