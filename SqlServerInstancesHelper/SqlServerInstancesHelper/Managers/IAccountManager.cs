using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlServerInstancesHelper.Managers {
    public interface IAccountManager {
        List<string> GetAccountSettings(string ServerInstance);
        string GetMatchingPassword(string username);
        string GetSavedConnectionString();
        List<string> GetUsernames();
        void SaveAccountSettings(string username, string password);
        void SaveAccountSettingsWithoutPassword(string username);
        void SaveConnectionStringSettings();
        void SaveNewConnectionString(string ConnString);
    }
}
