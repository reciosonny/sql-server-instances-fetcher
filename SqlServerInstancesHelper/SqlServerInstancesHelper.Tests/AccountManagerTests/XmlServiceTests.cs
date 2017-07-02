using NSubstitute;
using NUnit.Framework;
using SqlServerInstancesHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlServerInstancesHelper.Tests.AccountManagerTests {
    public class XmlServiceTests {

        [Test]
        public void GetUsernames_Should_FetchNamesFromXmlFile() {
            var mockXmlService = new FakeXmlService();
            mockXmlService.Usernames = new List<string>() { "test1", "test2" };

            List<string> result = mockXmlService.GetUsernames();

            Assert.AreEqual("test1", result[0]);
        }

        [Test]
        public void CheckXmlFile_Should_CheckIfFileExists() {
            var stubXmlService = new FakeXmlService();
            stubXmlService.ExistingXmlFile = "myXmlFile.xml";

            bool result = stubXmlService.CheckXmlFile("myXmlFile.xml");

            Assert.True(result);
        }

        [Test]
        public void LoadXmlFile_WhenCalled_CallsTheGetFileService() {
            //ARRANGE
            IFileService stubFileService = Substitute.For<IFileService>();
            var mockXmlService = new FakeXmlService(stubFileService);

            stubFileService.CheckFile(Arg.Any<string>()).Returns(true);
            stubFileService.GetFile(Arg.Any<string>()).Returns("accounts.xml");

            //ACT
            mockXmlService.LoadXmlFile();

            //ASSERT
            stubFileService.Received().GetFile(Arg.Any<string>());
        }

        [Test]
        public void LoadXmlFile_WhenCalled_ReturnsTheFilename() {
            //ARRANGE
            IFileService stubFileService = Substitute.For<IFileService>();
            var mockXmlService = new FakeXmlService(stubFileService);
            stubFileService.CheckFile(Arg.Any<string>()).Returns(true);

            stubFileService.GetFile(Arg.Any<string>()).Returns("accounts.xml");

            //ACT
            mockXmlService.LoadXmlFile();

            //ASSERT
            Assert.AreEqual("accounts.xml", mockXmlService.ExistingXmlFile);
        }

        [Test]
        public void LoadXmlFile_IfFileDoesNotExist_ShouldCreateXmlFileAndReturnFilename() {
            //ARRANGE
            IFileService stubFileService = Substitute.For<IFileService>();
            var mockXmlService = new FakeXmlService(stubFileService);

            stubFileService.CreateFile(Arg.Any<string>()).Returns("accounts.xml");

            //ACT
            mockXmlService.LoadXmlFile();

            //ASSERT
            Assert.AreEqual("accounts.xml", mockXmlService.ExistingXmlFile);


        }


    }
}
