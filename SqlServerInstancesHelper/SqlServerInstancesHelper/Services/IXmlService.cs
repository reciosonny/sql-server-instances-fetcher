using System.Collections.Generic;

namespace SqlServerInstancesHelper.Services {
    public interface IXmlService {
        List<string> GetUsernames();
    }
}