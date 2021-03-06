﻿
using System;
using System.IO;

namespace SqlServerInstancesHelper.Services {
    /// <summary>
    /// No need to write tests in this service. This is not testable.
    /// </summary>
    public class FileService : IFileService {
        public FileService() {
        }

        public bool DeleteFile(string v) {
            if (File.Exists(v)) {
                File.Delete(v);
                return true;
            }

            return false;
        }

        public bool CheckFile(string v) {
            throw new NotImplementedException();
        }

        public string CreateFile(string file) {

            if (!File.Exists(file)) {
                var fileStream = File.Create(file);
                return fileStream.Name;
                //using (var fileStream = File.Create(file)) {
                //    return fileStream.Name;
                //}
            }

            return "";
        }

        public string GetFile(string file) {

            if (File.Exists(file)) {
                using (var fileStream = File.OpenRead(file))
                    return fileStream.Name;

            }

            return "";
        }

        public bool CheckFileContents(string v1, string v2) {
            throw new NotImplementedException();
        }
    }
}