using System;
using System.Collections.Generic;
using System.IO;
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

        private IFileService fileService;
        public FakeXmlService(IFileService fileService) {
            this.fileService = fileService;
        }

        public bool CreateXmlFile(string v) {
            throw new NotImplementedException();
        }

        public bool AddNodeElement(string v1, string v2) {
            throw new NotImplementedException();
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

            try {
                if (!fileService.CheckFile(FILENAME)) {
                    ExistingXmlFile = fileService.CreateFile(FILENAME);
                } else {
                    //TODO: create a test that throws IOException errors and create ways to address it.
                    ExistingXmlFile = fileService.GetFile(FILENAME);
                }
            } catch (IOException ex) {
                throw new IOException("file is being used");
            }
        }

        public List<string> GetStringLists(string field) {
            throw new NotImplementedException();
        }

        public List<string> QueryResults() {
            throw new NotImplementedException();
        }
    }
}
