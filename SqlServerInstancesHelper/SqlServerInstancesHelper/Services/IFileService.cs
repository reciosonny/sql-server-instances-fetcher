namespace SqlServerInstancesHelper.Services {
    public interface IFileService {
        string GetFile(string file);
        bool CheckFile(string file);
        string CreateFile(string file);
    }
}