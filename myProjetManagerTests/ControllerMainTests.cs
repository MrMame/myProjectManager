using NUnit.Framework;
using myProjectManager.Controller;

namespace Controller
{
    public class AccessControllerTests
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
    }
}