
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealSite.DBProvider;
using RealSite.DBProvider.Model;

namespace RealSiteAPI.Repository
{
    internal class FileReassignRepo : IFileReassign
    {

        private readonly AppDbContext _appDbContext;
        public FileReassignRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public FileReassign addFileReassign(FileReassign FileReassign)
        {
            throw new NotImplementedException();
        }

        public FileReassign deleteFileReassign(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileReassign> GetAll()
        {
            return _appDbContext.file_reassign_details.ToList(); //.employee_list.
        }

        public FileReassign GetFileReassign(int id)
        {
            throw new NotImplementedException();
        }

        public FileReassign updateFileReassign(FileReassign FileReassign)
        {
            throw new NotImplementedException();
        }
         
        public  IEnumerable<FileReassign> GetTop100()
        {
            var data = _appDbContext.file_reassign_details
                                     .OrderByDescending(f => f.created_on)
                                     .Take(100).ToList(); 

            return data;
        }
    }
}
