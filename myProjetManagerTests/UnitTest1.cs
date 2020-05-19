using NUnit.Framework;
using myProjectManager.Controller;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReferencesToProjectManagerOK()
        {

            myProjectManager.Controller.AccessController theAccesController = new AccessController();

            //Assert.IsNotNull(theAccesController, "Instance Error : Couldn't create instance of AccessController Class.");

            //Assert.Pass();
        }
    }
}