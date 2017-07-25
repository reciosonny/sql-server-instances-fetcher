using SqlServerInstancesHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace SqlServerInstancesHelper.ConsoleApp {
    class Program {
        static void Main(string[] args) {

            //var fileService = new FileService();
            //var filepath = fileService.CreateFile("accounts.xml");
            //Console.WriteLine("====Created file====");
            //Console.WriteLine(filepath);

            //Console.WriteLine("====File saved====");
            //Console.WriteLine(fileService.GetFile("accounts.xml"));

            //fileService.DeleteFile("accounts.xml");

            //Console.ReadLine();


            //Creates xml document
            var doc = new XDocument(new XElement("FileDetails",
                new XElement("names", "myname"),
                new XElement("version", "v2")
            ));
            Console.WriteLine("testing testing...");

            doc.Save("Sample.xml");

            var loadXml = XElement.Load("Sample.xml");
            XNamespace df = loadXml.Name.Namespace;
            Console.WriteLine((string)loadXml.Element(df + "version"));


            //loads XML file and add another node
            var loadDocXml = XDocument.Load("Sample.xml");
            loadDocXml.Element("FileDetails").Add(new XElement("test", "test2"));
            loadDocXml.Save("Sample.xml");



            //checks whether XML Element exists.
            bool exists = loadDocXml.Elements("FileDetails").Elements("test").Any();

            Console.WriteLine("is exists: " + exists);


            var xmlService = new XmlService();
            Console.WriteLine(xmlService.AddNodeElement("mynode", "mynodevalue"));

        }
    }
}
