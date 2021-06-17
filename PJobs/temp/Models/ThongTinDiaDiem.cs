using System;
using System.Collections.Generic;

#nullable disable

namespace PJobs.Models
{
    public partial class ThongTinDiaDiem
    {
        public long Id { get; set; }
        public long MaThanhPho { get; set; }
        public long MaQuan { get; set; }
        public long MaNhaTuyenDung { get; set; }

        public virtual NhaTuyenDung MaNhaTuyenDungNavigation { get; set; }
        public virtual QuanHuyen MaQuanNavigation { get; set; }
        public virtual ThanhPho MaThanhPhoNavigation { get; set; }
    }
}
