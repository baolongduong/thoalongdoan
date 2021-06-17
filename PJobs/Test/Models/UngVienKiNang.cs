using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class UngVienKiNang
    {
        public long MaUngVien { get; set; }
        public int MaKiNang { get; set; }

        public virtual KiNang MaKiNangNavigation { get; set; }
        public virtual UngVien MaUngVienNavigation { get; set; }
    }
}
