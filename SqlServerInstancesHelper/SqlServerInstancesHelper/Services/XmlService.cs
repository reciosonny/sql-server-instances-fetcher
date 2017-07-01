using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlServerInstancesHelper.Services {
    public class FakeXmlService : IXmlService {
        public List<string> Usernames;

        public List<string> GetUsernames() {
            return Usernames;
        }
    }
}
