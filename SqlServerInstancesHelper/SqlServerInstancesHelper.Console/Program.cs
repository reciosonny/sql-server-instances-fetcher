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


            var doc = new XDocument(new XElement("FileDetails",
                new XElement("names", "myname"),
                new XElement("version", "v2")
            ));
            Console.WriteLine("testing testing...");

            doc.Save("Sample.xml");
        }
    }
}
