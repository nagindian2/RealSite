using Microsoft.EntityFrameworkCore;
using RealSite.DBProvider.Model;
using System.Data;

namespace RealSite.DBProvider
{
    public class  AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) :base(options) 
        {

            
        }
        public DbSet<Employee> employee_list {  get; set; }
        public DbSet<FileReassign> file_reassign_details { get; set; }
    }
}
