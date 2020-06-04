using NUnit.Framework;
using myProjectManager.Controller;
using myProjectManager.Views;
using myProjectManager.Model;
using System.Collections.Generic;

namespace Controller
{
    public class ContentController_Test
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateBlankReference()
        {
            ContentController theController = ContentController.GetContentCrontroller();
            Assert.IsNotNull(theController, "Error create Blank instance");
        }

        [Test]
        public void CreateFull()
        {
            MainView theView        = new MainView();
            ProjectsModel theModel   = ProjectsModel.GetContentModel();
            ContentController theController = ContentController.GetContentCrontroller(theView, theModel);
            Assert.IsNotNull(theController, "Error create Full instance");
        }

        [Test]
        public void AddProjects(){

            // Create The controller with view and model

            Ich Glaube die MainView muss ein MockObject werden!!
            MainView theView = new MainView();


            ProjectsModel theModel = ProjectsModel.GetContentModel();
            ContentController theController = ContentController.GetContentCrontroller(theView, theModel);
            // Create an example Project
            Project theExampleProject = CreateExampleProject_A();
            // add the project to the controller
            theController.AddProject(theExampleProject);

            // Check if Controller Project is the same
            Assert.AreEqual(theExampleProject, theController.GetModel().ReadOnlyCollectionOfProjects[0],"Example Project in Controllers List is not indentically");
        }




        private Project CreateExampleProject_A()
        {
            // Create Project
            Project theProject_A = Project.GetProject("Dummy Project 1");

            // Email Folder with two EmailFiles
            SubFolder theEMailsFolder = SubFolder.GetSubFolder("EMailFolder", "Folder for EMails");
            SubFile theEmailFile_1 = SubFile.GetSubFile("Email From Jon", "First Example Mail");
            SubFile theEmailFile_2 = SubFile.GetSubFile("Email From the Internet", "Another Mail from the net");
            theEMailsFolder.AddContent(theEmailFile_1);
            theEMailsFolder.AddContent(theEmailFile_2);

            theProject_A.AddContent(theEMailsFolder);

            /* Documentation Folder
            Dummy Project 1 +
                            |
                            |
                            + EMailFolder       +
                            |                   |
                            |                   + Email From Jon
                            |                   |
                            |                   + Email From the Internet
                            |
                            + Documentations    +
                                                |
                                                + TableOfContent.txt
                                                |
                                                + Docs_A +
                                                |        |
                                                |        + Docs_A_File_1.doc
                                                |        |
                                                |        + Docs_A_File_2.doc
                                                |
                                                |
                                                + Docs_B +
                                                        |
                                                        + Docs_B_File_1.jpg
                                                        |
                                                        + Docs_B_File_2.jpg

             */

            SubFolder docsA = SubFolder.GetSubFolder("Docs_A", "Docs_A Subfolder");
            SubFile docsAFile1 = SubFile.GetSubFile("Docs_A_File_1.doc", "DocsA1 File");
            SubFile docsAFile2 = SubFile.GetSubFile("Docs_A_File_2.doc", "DocsA2 File");
            docsA.AddContent(docsAFile1);
            docsA.AddContent(docsAFile2);

            SubFolder docsB = SubFolder.GetSubFolder("Docs_B", "Docs_B Subfolder");
            SubFile docsBFile1 = SubFile.GetSubFile("Docs_B_File_1.jpg", "DocsB1 File");
            SubFile docsBFile2 = SubFile.GetSubFile("Docs_B_File_2.jpg", "DocsB2 File");
            docsB.AddContent(docsBFile1);
            docsB.AddContent(docsBFile2);

            SubFolder theDocumentationFolder = SubFolder.GetSubFolder("Documentations", "Documentation Folders");
            SubFile TOCFile = SubFile.GetSubFile("TableofContent.txt", "Table of Contents File");
            theDocumentationFolder.AddContent(TOCFile);
            theDocumentationFolder.AddContent(docsA);
            theDocumentationFolder.AddContent(docsB);

            theProject_A.AddContent(theDocumentationFolder);



            return theProject_A;
        }
    }
}