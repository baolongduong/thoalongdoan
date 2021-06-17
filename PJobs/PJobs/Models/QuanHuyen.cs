using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class QuanHuyen
    {
        public QuanHuyen()
        {
            ThongTinDiaDiems = new HashSet<ThongTinDiaDiem>();
        }

        public long MaQuan { get; set; }
        public string TenQuan { get; set; }

        public virtual ICollection<ThongTinDiaDiem> ThongTinDiaDiems { get; set; }
    }
}
