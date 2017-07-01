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
            var stubXmlService = new FakeXmlService();
            stubXmlService.Usernames = new List<string>() { "test1", "test2" };

            List<string> result = stubXmlService.GetUsernames();

            Assert.AreEqual("test1", result[0]);
        }
    }
}
