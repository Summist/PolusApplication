using Microsoft.EntityFrameworkCore;
using PolusApplication.WinForms.Database.Entities;

namespace PolusApplication.WinForms.Database
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<OrgTechType> OrgTechTypes { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Demo24;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Message).HasMaxLength(200);

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.MasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Users");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Requests");
            });

            modelBuilder.Entity<OrgTechType>(entity =>
            {
                entity.ToTable("OrgTechType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.CompletionDate).HasColumnType("date");

                entity.Property(e => e.OrgTechModel).HasMaxLength(100);

                entity.Property(e => e.ProblemDescription).HasMaxLength(200);

                entity.Property(e => e.RepairParts).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.RequestClients)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_Users1");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.RequestMasters)
                    .HasForeignKey(d => d.MasterId)
                    .HasConstraintName("FK_Requests_Users");

                entity.HasOne(d => d.OrgTechType)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.OrgTechTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_OrgTechType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Requests_Statuses");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
