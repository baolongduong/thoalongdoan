using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class ThanhPho
    {
        public ThanhPho()
        {
            ThongTinDiaDiems = new HashSet<ThongTinDiaDiem>();
        }

        public long MaThanhPho { get; set; }
        public string TenThanhPho { get; set; }

        public virtual ICollection<ThongTinDiaDiem> ThongTinDiaDiems { get; set; }
    }
}
