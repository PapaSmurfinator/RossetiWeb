using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RossetiWeb.Mod
{
    public partial class auradbContext : DbContext
    {
        public auradbContext()
        {
        }

        public auradbContext(DbContextOptions<auradbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<_3version> _3version { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=192.168.116.235;User ID=aura;Password=aura@123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_3version>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("3Version");

                entity.Property(e => e.IaВл33009330KV).HasColumnName("Ia ВЛ-330-09 330 kV");

                entity.Property(e => e.IaВл330Дерб330KV).HasColumnName("Ia ВЛ-330-Дерб# 330 kV");

                entity.Property(e => e.IbВл33009330KV).HasColumnName("Ib ВЛ-330-09 330 kV");

                entity.Property(e => e.IbВл330Дерб330KV).HasColumnName("Ib ВЛ-330-Дерб# 330 kV");

                entity.Property(e => e.IcВл33009330KV).HasColumnName("Ic ВЛ-330-09 330 kV");

                entity.Property(e => e.IcВл330Дерб330KV).HasColumnName("Ic ВЛ-330-Дерб# 330 kV");

                entity.Property(e => e.TСек).HasColumnName("t, сек#");

                entity.Property(e => e.UaВл33009330KV).HasColumnName("Ua ВЛ-330-09 330 kV");

                entity.Property(e => e.UaВл330Дерб330KV).HasColumnName("Ua ВЛ-330-Дерб# 330 kV");

                entity.Property(e => e.UbВл33009330KV).HasColumnName("Ub ВЛ-330-09 330 kV");

                entity.Property(e => e.UbВл330Дерб330KV).HasColumnName("Ub ВЛ-330-Дерб# 330 kV");

                entity.Property(e => e.UcВл33009330KV).HasColumnName("Uc ВЛ-330-09 330 kV");

                entity.Property(e => e.UcВл330Дерб330KV).HasColumnName("Uc ВЛ-330-Дерб# 330 kV");

                entity.Property(e => e._3i0Вл330Дерб330KV).HasColumnName("3I0 ВЛ-330-Дерб# 330 kV");

                entity.Property(e => e._3u0Вл33009330KV).HasColumnName("3U0 ВЛ-330-09 330 kV");

                entity.Property(e => e._3u0Вл330Дерб330KV).HasColumnName("3U0 ВЛ-330-Дерб# 330 kV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
