using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlServerInstancesHelper.Services;

namespace SqlServerInstancesHelper.Managers {
    public class AccountManager : IAccountManager {
        private IXmlService xmlService;

        public AccountManager() {

        }

        public AccountManager(IXmlService xmlService) {
            this.xmlService = xmlService;
        }

        public List<string> GetAccountSettings(string ServerInstance) {
            throw new NotImplementedException();
        }

        public string GetMatchingPassword(string username) {
            throw new NotImplementedException();
        }

        public string GetSavedConnectionString() {
            throw new NotImplementedException();
        }

        public List<string> GetUsernames() {
            return xmlService.GetUsernames();
        }

        public void SaveAccountSettings(string username, string password) {
            throw new NotImplementedException();
        }

        public void SaveAccountSettingsWithoutPassword(string username) {
            throw new NotImplementedException();
        }

        public void SaveConnectionStringSettings() {
            throw new NotImplementedException();
        }

        public void SaveNewConnectionString(string ConnString) {
            throw new NotImplementedException();
        }
    }
}
