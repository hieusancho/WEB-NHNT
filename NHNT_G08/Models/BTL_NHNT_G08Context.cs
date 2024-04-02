using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NHNT_G08.Models
{
    public partial class BTL_NHNT_G08Context : DbContext
    {
        public BTL_NHNT_G08Context()
        {
        }

        public BTL_NHNT_G08Context(DbContextOptions<BTL_NHNT_G08Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDanhGiaPhong> TblDanhGiaPhongs { get; set; }
        public virtual DbSet<TblDmTaiKhoan> TblDmTaiKhoans { get; set; }
        public virtual DbSet<TblHinhAnh> TblHinhAnhs { get; set; }
        public virtual DbSet<TblPhong> TblPhongs { get; set; }
        public virtual DbSet<TblTaiKhoan> TblTaiKhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ADMIN\\MAYAO;Initial Catalog=BTL_NHNT_G08;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDanhGiaPhong>(entity =>
            {
                entity.HasKey(e => e.MaDanhGia)
                    .HasName("PK__tblDanhG__6B15DD9A5A8D16EB");

                entity.ToTable("tblDanhGiaPhong");

                entity.Property(e => e.MaDanhGia).HasColumnName("maDanhGia");

                entity.Property(e => e.MaPhong).HasColumnName("maPhong");

                entity.Property(e => e.MaTaiKhoan).HasColumnName("maTaiKhoan");

                entity.Property(e => e.SoSao).HasColumnName("soSao");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.TblDanhGiaPhongs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblDanhGi__maPho__2D27B809");

                entity.HasOne(d => d.MaTaiKhoanNavigation)
                    .WithMany(p => p.TblDanhGiaPhongs)
                    .HasForeignKey(d => d.MaTaiKhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblDanhGi__maTai__2E1BDC42");
            });

            modelBuilder.Entity<TblDmTaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaDmTaiKhoan)
                    .HasName("PK__tblDmTai__7CAB5CC35611354A");

                entity.ToTable("tblDmTaiKhoan");

                entity.Property(e => e.MaDmTaiKhoan).HasColumnName("maDmTaiKhoan");

                entity.Property(e => e.TenLoaiTk)
                    .HasMaxLength(50)
                    .HasColumnName("tenLoaiTK");
            });

            modelBuilder.Entity<TblHinhAnh>(entity =>
            {
                entity.HasKey(e => e.MaAnh)
                    .HasName("PK__tblHinhA__184D77366FC15403");

                entity.ToTable("tblHinhAnh");

                entity.Property(e => e.MaAnh).HasColumnName("maAnh");

                entity.Property(e => e.DuongDan)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("duongDan");

                entity.Property(e => e.MaPhong).HasColumnName("maPhong");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.TblHinhAnhs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblHinhAn__maPho__2F10007B");
            });

            modelBuilder.Entity<TblPhong>(entity =>
            {
                entity.HasKey(e => e.MaPhong)
                    .HasName("PK__tblPhong__4CD55E10286293F1");

                entity.ToTable("tblPhong");

                entity.Property(e => e.MaPhong).HasColumnName("maPhong");

                entity.Property(e => e.ChiTietPhong)
                    .HasMaxLength(1000)
                    .HasColumnName("chiTietPhong");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(500)
                    .HasColumnName("diaChi");

                entity.Property(e => e.DienTich).HasColumnName("dienTich");

                entity.Property(e => e.GiaDien).HasColumnName("giaDien");

                entity.Property(e => e.GiaNuoc).HasColumnName("giaNuoc");

                entity.Property(e => e.GiaPhong).HasColumnName("giaPhong");

                entity.Property(e => e.MaTaiKhoan).HasColumnName("maTaiKhoan");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("soDienThoai");

                entity.Property(e => e.TenPhong)
                    .HasMaxLength(200)
                    .HasColumnName("tenPhong");

                entity.Property(e => e.TrangThaiBaiDang)
                    .HasMaxLength(50)
                    .HasColumnName("trangThaiBaiDang");

                entity.Property(e => e.TrangThaiPhong)
                    .HasMaxLength(50)
                    .HasColumnName("trangThaiPhong");

                entity.HasOne(d => d.MaTaiKhoanNavigation)
                    .WithMany(p => p.TblPhongs)
                    .HasForeignKey(d => d.MaTaiKhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblPhong__maTaiK__300424B4");
            });

            modelBuilder.Entity<TblTaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK__tblTaiKh__8FFF6A9D36C74153");

                entity.ToTable("tblTaiKhoan");

                entity.Property(e => e.MaTaiKhoan).HasColumnName("maTaiKhoan");

                entity.Property(e => e.AnhDaiDien)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("anhDaiDien");

                entity.Property(e => e.GioiTinh)
                    .HasColumnName("gioiTinh")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HoTenNguoiDung)
                    .HasMaxLength(50)
                    .HasColumnName("hoTenNguoiDung");

                entity.Property(e => e.MaDmTaiKhoan).HasColumnName("maDmTaiKhoan");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("matKhau");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("soDienThoai");

                entity.Property(e => e.SoLanSai).HasColumnName("soLanSai");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tenDangNhap");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trangThai");

                entity.HasOne(d => d.MaDmTaiKhoanNavigation)
                    .WithMany(p => p.TblTaiKhoans)
                    .HasForeignKey(d => d.MaDmTaiKhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblTaiKho__maDmT__30F848ED");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
