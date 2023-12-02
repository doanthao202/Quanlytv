using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace A_DAL.Model
{
    public partial class DUAN1Context : DbContext
    {
        public DUAN1Context()
        {
        }

        public DUAN1Context(DbContextOptions<DUAN1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Docgium> Docgia { get; set; } = null!;
        public virtual DbSet<Hangthanhvien> Hangthanhviens { get; set; } = null!;
        public virtual DbSet<Ngonngu> Ngonngus { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Nxb> Nxbs { get; set; } = null!;
        public virtual DbSet<Phieumuon> Phieumuons { get; set; } = null!;
        public virtual DbSet<Phieumuonct> Phieumuoncts { get; set; } = null!;
        public virtual DbSet<Phieutra> Phieutras { get; set; } = null!;
        public virtual DbSet<Phieutract> Phieutracts { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<SachTacgium> SachTacgia { get; set; } = null!;
        public virtual DbSet<Sachchitiet> Sachchitiets { get; set; } = null!;
        public virtual DbSet<SachctHang> SachctHangs { get; set; } = null!;
        public virtual DbSet<Tacgium> Tacgia { get; set; } = null!;
        public virtual DbSet<Theloai> Theloais { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NHT2019\\SQLEXPRESS;Database=DUAN1;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docgium>(entity =>
            {
                entity.ToTable("DOCGIA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Hanthe)
                    .HasColumnType("datetime")
                    .HasColumnName("HANTHE");

                entity.Property(e => e.Hoten)
                    .HasMaxLength(50)
                    .HasColumnName("HOTEN");

                entity.Property(e => e.Idhang).HasColumnName("IDHANG");

                entity.Property(e => e.Ngaycapthe)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYCAPTHE");

                entity.Property(e => e.Ngayhieuluc)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYHIEULUC");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.IdhangNavigation)
                    .WithMany(p => p.Docgia)
                    .HasForeignKey(d => d.Idhang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCGIA_HANG");
            });

            modelBuilder.Entity<Hangthanhvien>(entity =>
            {
                entity.ToTable("HANGTHANHVIEN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dongia)
                    .HasColumnType("money")
                    .HasColumnName("DONGIA");

                entity.Property(e => e.Tenhang)
                    .HasMaxLength(50)
                    .HasColumnName("TENHANG");

                entity.Property(e => e.Thoigianhieuluc).HasColumnName("THOIGIANHIEULUC");
            });

            modelBuilder.Entity<Ngonngu>(entity =>
            {
                entity.ToTable("NGONNGU");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tennn)
                    .HasMaxLength(50)
                    .HasColumnName("TENNN");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Hoten)
                    .HasMaxLength(50)
                    .HasColumnName("HOTEN");

                entity.Property(e => e.Pass)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PASS");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.Property(e => e.Vaitro)
                    .HasMaxLength(20)
                    .HasColumnName("VAITRO");
            });

            modelBuilder.Entity<Nxb>(entity =>
            {
                entity.ToTable("NXB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Tennxb)
                    .HasMaxLength(50)
                    .HasColumnName("TENNXB");
            });

            modelBuilder.Entity<Phieumuon>(entity =>
            {
                entity.ToTable("PHIEUMUON");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iddocgia).HasColumnName("IDDOCGIA");

                entity.Property(e => e.Idnhanvien).HasColumnName("IDNHANVIEN");

                entity.Property(e => e.Ngaymuon)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYMUON");

                entity.Property(e => e.Ngaytradukien)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTRADUKIEN");

                entity.Property(e => e.Phimuon)
                    .HasColumnType("money")
                    .HasColumnName("PHIMUON");

                entity.Property(e => e.Tiencoc)
                    .HasColumnType("money")
                    .HasColumnName("TIENCOC");

                entity.Property(e => e.Tinhtrang).HasColumnName("TINHTRANG");

                entity.HasOne(d => d.IddocgiaNavigation)
                    .WithMany(p => p.Phieumuons)
                    .HasForeignKey(d => d.Iddocgia)
                    .HasConstraintName("FK_DOCGIA_PHIEUMUON");

                entity.HasOne(d => d.IdnhanvienNavigation)
                    .WithMany(p => p.Phieumuons)
                    .HasForeignKey(d => d.Idnhanvien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NHANVIEN_PHIEUMUON");
            });

            modelBuilder.Entity<Phieumuonct>(entity =>
            {
                entity.ToTable("PHIEUMUONCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Idphieumuon).HasColumnName("IDPHIEUMUON");

                entity.Property(e => e.Idsachct).HasColumnName("IDSACHCT");

                entity.HasOne(d => d.IdphieumuonNavigation)
                    .WithMany(p => p.Phieumuoncts)
                    .HasForeignKey(d => d.Idphieumuon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUMUON_PHIEUMUONCT");

                entity.HasOne(d => d.IdsachctNavigation)
                    .WithMany(p => p.Phieumuoncts)
                    .HasForeignKey(d => d.Idsachct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SACHCHITIET_PHIEUMUONCT");
            });

            modelBuilder.Entity<Phieutra>(entity =>
            {
                entity.ToTable("PHIEUTRA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Hoancoc)
                    .HasColumnType("money")
                    .HasColumnName("HOANCOC");

                entity.Property(e => e.Iddocgia).HasColumnName("IDDOCGIA");

                entity.Property(e => e.Idnhanvien).HasColumnName("IDNHANVIEN");

                entity.Property(e => e.Lydophat)
                    .HasColumnType("money")
                    .HasColumnName("LYDOPHAT");

                entity.Property(e => e.Ngaytra)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTRA");

                entity.Property(e => e.Tienphat)
                    .HasColumnType("money")
                    .HasColumnName("TIENPHAT");

                entity.Property(e => e.Tinhtrangtra).HasColumnName("TINHTRANGTRA");

                entity.HasOne(d => d.IddocgiaNavigation)
                    .WithMany(p => p.Phieutras)
                    .HasForeignKey(d => d.Iddocgia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCGIA_PHIEUTRA");

                entity.HasOne(d => d.IdnhanvienNavigation)
                    .WithMany(p => p.Phieutras)
                    .HasForeignKey(d => d.Idnhanvien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NHANVIEN_PHIEUTRA");
            });

            modelBuilder.Entity<Phieutract>(entity =>
            {
                entity.ToTable("PHIEUTRACT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Idphieumuonct).HasColumnName("IDPHIEUMUONCT");

                entity.Property(e => e.Idphieutra).HasColumnName("IDPHIEUTRA");

                entity.HasOne(d => d.IdphieumuonctNavigation)
                    .WithMany(p => p.Phieutracts)
                    .HasForeignKey(d => d.Idphieumuonct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUMUONCT_PHIEUTRACT");

                entity.HasOne(d => d.IdphieutraNavigation)
                    .WithMany(p => p.Phieutracts)
                    .HasForeignKey(d => d.Idphieutra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUTRA_PHIEUTRACT");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("SACH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Namxuatban).HasColumnName("NAMXUATBAN");

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYNHAP");

                entity.Property(e => e.Tensach)
                    .HasMaxLength(50)
                    .HasColumnName("TENSACH");
            });

            modelBuilder.Entity<SachTacgium>(entity =>
            {
                entity.ToTable("SACH_TACGIA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Idsach).HasColumnName("IDSACH");

                entity.Property(e => e.Idtacgia).HasColumnName("IDTACGIA");

                entity.Property(e => e.Vaitro)
                    .HasMaxLength(20)
                    .HasColumnName("VAITRO");

                entity.HasOne(d => d.IdsachNavigation)
                    .WithMany(p => p.SachTacgia)
                    .HasForeignKey(d => d.Idsach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SACH_SACH_TACGIA");

                entity.HasOne(d => d.IdtacgiaNavigation)
                    .WithMany(p => p.SachTacgia)
                    .HasForeignKey(d => d.Idtacgia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TACGIA_SACH_TACGIA");
            });

            modelBuilder.Entity<Sachchitiet>(entity =>
            {
                entity.ToTable("SACHCHITIET");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dotuoidocsach).HasColumnName("DOTUOIDOCSACH");

                entity.Property(e => e.Giasach)
                    .HasColumnType("money")
                    .HasColumnName("GIASACH");

                entity.Property(e => e.Idngonngu).HasColumnName("IDNGONNGU");

                entity.Property(e => e.Idnxb).HasColumnName("IDNXB");

                entity.Property(e => e.Idsach).HasColumnName("IDSACH");

                entity.Property(e => e.Lantaiban).HasColumnName("LANTAIBAN");

                entity.Property(e => e.Tinhtrang).HasColumnName("TINHTRANG");

                entity.HasOne(d => d.IdngonnguNavigation)
                    .WithMany(p => p.Sachchitiets)
                    .HasForeignKey(d => d.Idngonngu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NGONNGU_SACHCHITIET");

                entity.HasOne(d => d.IdnxbNavigation)
                    .WithMany(p => p.Sachchitiets)
                    .HasForeignKey(d => d.Idnxb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NXB_SACHCHITIET");

                entity.HasOne(d => d.IdsachNavigation)
                    .WithMany(p => p.Sachchitiets)
                    .HasForeignKey(d => d.Idsach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SACH_SACHCHITIET");
            });

            modelBuilder.Entity<SachctHang>(entity =>
            {
                entity.ToTable("SACHCT_HANG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idhang).HasColumnName("IDHANG");

                entity.Property(e => e.Idsachct).HasColumnName("IDSACHCT");

                entity.HasOne(d => d.IdhangNavigation)
                    .WithMany(p => p.SachctHangs)
                    .HasForeignKey(d => d.Idhang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HANGTHANHVIEN_SACHCT_HANG");

                entity.HasOne(d => d.IdsachctNavigation)
                    .WithMany(p => p.SachctHangs)
                    .HasForeignKey(d => d.Idsachct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SACHCHITIET_SACHCT_HANG");
            });

            modelBuilder.Entity<Tacgium>(entity =>
            {
                entity.ToTable("TACGIA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Tentacgia)
                    .HasMaxLength(50)
                    .HasColumnName("TENTACGIA");
            });

            modelBuilder.Entity<Theloai>(entity =>
            {
                entity.ToTable("THELOAI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tentheloai)
                    .HasMaxLength(50)
                    .HasColumnName("TENTHELOAI");

                entity.Property(e => e.Vitri)
                    .HasMaxLength(50)
                    .HasColumnName("VITRI");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
