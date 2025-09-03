using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSite.DBProvider.Model
{
    [Keyless]
    public class FileReassign
    {
     //   public int id { get; set; }
        public required int reassign_detail_id { get; set; }
        public required int request_id { get; set; }
        public int? reassign_from_id { get; set; }
        public required int reassign_to_id { get; set; }
        public string? reassign_from_name { get; set; }
        public string? reassign_to_name { get; set; }
        public required string reassign_type { get; set; }
        public required int created_by { get; set; }
        public required DateTime created_on { get; set; }
        public int? updated_by { get; set; }
        public DateTime? updated_on { get; set; }
    }
}
