using NSubstitute;
using NUnit.Framework;
using SqlServerInstancesHelper.Managers;
using SqlServerInstancesHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlServerInstancesHelper.Tests.AccountManagerTests {
    [TestFixture]
    class AccountManagerTest {

        [Test]
        public void AccountManager_GetUsernames_Should_FetchUsernames() {
            var stubXmlService = Substitute.For<IXmlService>();
            stubXmlService
                    .GetStringLists(Arg.Any<string>())
                    .Returns(new List<string>() { "test1", "test2" });
            //stubXmlService.Usernames = new List<string>() { "test1", "test2" };

            var mockAccountManager = new AccountManager(stubXmlService);
            var result = mockAccountManager.GetUsernames();

            Assert.AreEqual("test1", result[0]);
        }

    }
}
