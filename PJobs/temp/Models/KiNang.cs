using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class KiNang
    {
        public KiNang()
        {
            UngVienKiNangs = new HashSet<UngVienKiNang>();
        }

        public int MaKiNang { get; set; }
        public string TenKiNang { get; set; }

        public virtual ICollection<UngVienKiNang> UngVienKiNangs { get; set; }
    }
}
