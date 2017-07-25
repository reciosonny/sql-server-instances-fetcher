using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SqlServerInstancesHelper.Services {
    public class XmlService {
        private IFileService stubFileService;

        #region Stubs / Fakes
        public bool StubCheckNodeColumn { get; set; }
        #endregion

        /// <summary>
        /// A flag whether the class is under Unit Testing / TDD for automation tests
        /// </summary>
        public bool TEST_MODE { get; set; }
        private readonly string XML_FILENAME = "accounts.xml";

        public XmlService() {

        }

        public XmlService(IFileService stubFileService) {
            this.stubFileService = stubFileService;
        }

        public bool CreateXmlFile(string xElementTableName) {
            try {
                stubFileService.CreateFile(XML_FILENAME);
            } catch (Exception ex) {
                throw;
            }

            return stubFileService.CheckFile(XML_FILENAME);
        }

        public bool AddNodeElement(string nodeColumn, string nodeValue) {

            bool result = false;
            try {
                result = CheckNodeColumn(nodeColumn); //stubFileService.CheckFileContents(XML_FILENAME, nodeColumn);
            } catch (Exception ex) {

                throw;
            }

            return result;
        }


        private bool CheckNodeColumn(string nodeColumn) {

            if (TEST_MODE) {
                return StubCheckNodeColumn;
            }

            //todo: add implementation here...
            var doc = new XDocument(new XElement("FileDetails", ""));
            doc.Save("Sample.xml");

            //loads XML file and add another node
            var loadDocXml = XDocument.Load("Sample.xml");
            loadDocXml.Element("FileDetails").Add(new XElement(nodeColumn, "test2"));
            loadDocXml.Save("Sample.xml");


            //checks whether XML Element exists.
            bool exists = loadDocXml.Elements("FileDetails").Elements(nodeColumn).Any();

            return exists;
        }
    }
}
