using SqlServerInstancesHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlServerInstancesHelper.Console {
    class Program {
        static void Main(string[] args) {

            var fileService = new FileService();
            var filepath = fileService.CreateFile("accounts.xml");
            System.Console.WriteLine("====Created file====");
            System.Console.WriteLine(filepath);

            System.Console.WriteLine("====File saved====");
            System.Console.WriteLine(fileService.GetFile("accounts.xml"));

            fileService.DeleteFile("accounts.xml");

            System.Console.ReadLine();
        }
    }
}
