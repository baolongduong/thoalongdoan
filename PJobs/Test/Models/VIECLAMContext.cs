using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Test.Models
{
    public partial class VIECLAMContext : DbContext
    {
        public VIECLAMContext()
        {
        }

        public VIECLAMContext(DbContextOptions<VIECLAMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<KiNang> KiNangs { get; set; }
        public virtual DbSet<NhaTuyenDung> NhaTuyenDungs { get; set; }
        public virtual DbSet<PhanHoi> PhanHois { get; set; }
        public virtual DbSet<ThongTinDiaDiem> ThongTinDiaDiems { get; set; }
        public virtual DbSet<ThongTinNganhNghe> ThongTinNganhNghes { get; set; }
        public virtual DbSet<TinTuyenDung> TinTuyenDungs { get; set; }
        public virtual DbSet<UngVien> UngViens { get; set; }
        public virtual DbSet<UngVienDangKy> UngVienDangKies { get; set; }
        public virtual DbSet<UngVienKiNang> UngVienKiNangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local)\\SQLEXPRESS; user id =sa;password=1;database=VIECLAM");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(e => e.MaBlog)
                    .HasName("PK__Blog__86827C73108B795B");

                entity.ToTable("Blog");

                entity.Property(e => e.MaBlog).ValueGeneratedNever();

                entity.Property(e => e.NoiDungBlog).IsRequired();

                entity.Property(e => e.TenBlog)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaNgheNavigation)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.MaNghe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Blog__MaNghe__1B0907CE");
            });

            modelBuilder.Entity<KiNang>(entity =>
            {
                entity.HasKey(e => e.MaKiNang);

                entity.ToTable("KiNang");

                entity.Property(e => e.Tenkinang).HasMaxLength(250);
            });

            modelBuilder.Entity<NhaTuyenDung>(entity =>
            {
                entity.HasKey(e => e.MaNhaTuyenDung)
                    .HasName("PK__NhaTuyen__2BDEB6A6014935CB");

                entity.ToTable("NhaTuyenDung");

                entity.Property(e => e.MaNhaTuyenDung).ValueGeneratedNever();

                entity.Property(e => e.AnhDaiDien).HasColumnType("image");

                entity.Property(e => e.DiaChiHoatDong)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MoTaCongTy).HasMaxLength(255);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.TenCongTy)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PhanHoi>(entity =>
            {
                entity.HasKey(e => e.MaPhanHoi)
                    .HasName("PK__PhanHoi__3458D20F0CBAE877");

                entity.ToTable("PhanHoi");

                entity.Property(e => e.MaPhanHoi).ValueGeneratedNever();

                entity.Property(e => e.NgayPhanHoi).HasColumnType("date");

                entity.Property(e => e.NoiDungPhanHoi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.MaCongTyNavigation)
                    .WithMany(p => p.PhanHois)
                    .HasForeignKey(d => d.MaCongTy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhanHoi__MaCongT__1920BF5C");

                entity.HasOne(d => d.MaUngVienNavigation)
                    .WithMany(p => p.PhanHois)
                    .HasForeignKey(d => d.MaUngVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhanHoi__MaUngVi__1FCDBCEB");
            });

            modelBuilder.Entity<ThongTinDiaDiem>(entity =>
            {
                entity.HasKey(e => new { e.MaThanhPho, e.MaQuanHuyen })
                    .HasName("PK__ThongTin__4CA3260C0519C6AF");

                entity.ToTable("ThongTinDiaDiem");
            });

            modelBuilder.Entity<ThongTinNganhNghe>(entity =>
            {
                entity.HasKey(e => e.MaNghe)
                    .HasName("PK__ThongTin__238150F708EA5793");

                entity.ToTable("ThongTinNganhNghe");

                entity.Property(e => e.MaNghe).ValueGeneratedNever();

                entity.Property(e => e.TenNghe).HasMaxLength(50);

                entity.HasOne(d => d.Ma)
                    .WithMany(p => p.ThongTinNganhNghes)
                    .HasForeignKey(d => new { d.MaThanhPho, d.MaQuanHuyen })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThongTinNganhNghe_ThongTinDiaDiem");
            });

            modelBuilder.Entity<TinTuyenDung>(entity =>
            {
                entity.HasKey(e => e.MaTinTuyenDung)
                    .HasName("PK__TinTuyen__34CFEE03145C0A3F");

                entity.ToTable("TinTuyenDung");

                entity.Property(e => e.MaTinTuyenDung).ValueGeneratedNever();

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hinhanh");

                entity.Property(e => e.HoSoYeuCau)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MoTaCongViec)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MucLuong).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NgayDang)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.QuyenLoi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tieude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tieude");

                entity.Property(e => e.ViTriTuyenDung)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaCongTyNavigation)
                    .WithMany(p => p.TinTuyenDungs)
                    .HasForeignKey(d => d.MaCongTy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TinTuyenD__MaCon__1BFD2C07");

                entity.HasOne(d => d.MaNganhNgheNavigation)
                    .WithMany(p => p.TinTuyenDungs)
                    .HasForeignKey(d => d.MaNganhNghe)
                    .HasConstraintName("FK_TinTuyenDung_ThongTinNganhNghe");
            });

            modelBuilder.Entity<UngVien>(entity =>
            {
                entity.HasKey(e => e.MaUngVien)
                    .HasName("PK__UngVien__8FDBA8A90AD2A005");

                entity.ToTable("UngVien");

                entity.Property(e => e.AnhDaiDien)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.DiaChiChiTiet)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileCv)
                    .HasMaxLength(255)
                    .HasColumnName("FileCV");

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<UngVienDangKy>(entity =>
            {
                entity.HasKey(e => e.MaDangKy);

                entity.ToTable("UngVienDangKy");

                entity.Property(e => e.MaDangKy).ValueGeneratedNever();

                entity.Property(e => e.NgayDangky).HasColumnType("date");

                entity.HasOne(d => d.MaTinTuyenDungNavigation)
                    .WithMany(p => p.UngVienDangKies)
                    .HasForeignKey(d => d.MaTinTuyenDung)
                    .HasConstraintName("FK_UngVienDangKy_TinTuyenDung");

                entity.HasOne(d => d.MaUngVienNavigation)
                    .WithMany(p => p.UngVienDangKies)
                    .HasForeignKey(d => d.MaUngVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UngVienDa__MaUng__276EDEB3");
            });

            modelBuilder.Entity<UngVienKiNang>(entity =>
            {
                entity.HasKey(e => new { e.MaUngVien, e.MaKiNang });

                entity.ToTable("UngVien_KiNang");

                entity.HasOne(d => d.MaKiNangNavigation)
                    .WithMany(p => p.UngVienKiNangs)
                    .HasForeignKey(d => d.MaKiNang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UngVien_KiNang_KiNang");

                entity.HasOne(d => d.MaUngVienNavigation)
                    .WithMany(p => p.UngVienKiNangs)
                    .HasForeignKey(d => d.MaUngVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UngVien_KiNang_UngVien");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
