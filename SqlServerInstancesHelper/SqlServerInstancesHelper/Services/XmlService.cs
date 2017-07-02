using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlServerInstancesHelper.Services {
    public class FakeXmlService : IXmlService {
        #region Seams/stubs
        public List<string> Usernames;
        public string ExistingXmlFile;
        #endregion

        private const string FILENAME = "accounts.xml";
        private const string MEM_ADDR = "000FEEA111";

        private IFileService stubFileService;
        public FakeXmlService(IFileService stubFileService) {
            this.stubFileService = stubFileService;
        }
        public FakeXmlService() {

        }

        public List<string> GetUsernames() {
            return Usernames;
        }

        public bool CheckXmlFile(string v) {
            if (ExistingXmlFile == v) {
                return true;
            }

            return false;
        }

        public void LoadXmlFile() {
            if (!stubFileService.CheckFile(FILENAME)) {
                ExistingXmlFile = stubFileService.CreateFile(FILENAME);
            } else {
                ExistingXmlFile = stubFileService.GetFile(FILENAME);
            }
        }
    }
}
