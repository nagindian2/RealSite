using RealSite.DBProvider.Model;

namespace RealSiteAPI.Repository
{
   internal interface  IFileReassign
    {
        FileReassign GetFileReassign(int id);
        IEnumerable<FileReassign> GetAll();
        FileReassign addFileReassign(FileReassign FileReassign);
        FileReassign updateFileReassign(FileReassign FileReassign);
        FileReassign deleteFileReassign(int id);
        IEnumerable<FileReassign> GetTop100();

    }
}
