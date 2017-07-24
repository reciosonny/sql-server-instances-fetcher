using System.Collections.Generic;

namespace SqlServerInstancesHelper.Services {
    public interface IXmlService {
        List<string> GetUsernames();
        bool CheckXmlFile(string v);
        void LoadXmlFile();
        List<string> GetStringLists(string field);
        List<string> QueryResults();
    }
}