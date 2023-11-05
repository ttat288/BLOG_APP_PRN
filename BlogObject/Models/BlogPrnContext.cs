using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BlogObject.Models
{
    public partial class BlogPrnContext : DbContext
    {
        public BlogPrnContext()
        {
        }

        public BlogPrnContext(DbContextOptions<BlogPrnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CommentTbl> CommentTbls { get; set; }
        public virtual DbSet<LikeTbl> LikeTbls { get; set; }
        public virtual DbSet<PostTbl> PostTbls { get; set; }
        public virtual DbSet<UserTbl> UserTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = GetConfiguration();
            string connectionString = configuration.GetConnectionString("ConnectionString");

            optionsBuilder.UseSqlServer(connectionString);
        }

        private IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CommentTbl>(entity =>
            {
                entity.HasKey(e => e.CmtId)
                    .HasName("pk_Comment");

                entity.ToTable("CommentTbl");

                entity.Property(e => e.CmtId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CmtID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PostID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.CommentTbls)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CmtPost");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommentTbls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CmtUser");
            });

            modelBuilder.Entity<LikeTbl>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PostId })
                    .HasName("pk_Like");

                entity.ToTable("LikeTbl");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.PostId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PostID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.LikeTbls)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LikePost");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LikeTbls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LikeUser");
            });

            modelBuilder.Entity<PostTbl>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("pk_Post");

                entity.ToTable("PostTbl");

                entity.Property(e => e.PostId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PostID");

                entity.Property(e => e.CoverImg)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Major)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostTbls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UserPost");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("pk_User");

                entity.ToTable("UserTbl");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Major)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
