using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FilmRegistartion.DateAccessLayer.DataModels
{
    public partial class FilmDbContext : DbContext
    {
        public FilmDbContext()
        {
        }

        public FilmDbContext(DbContextOptions<FilmDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmsToActor> FilmsToActors { get; set; }
        public virtual DbSet<FilmsToGenre> FilmsToGenres { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Films; User Id=sa;Password=1qazxsw2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.DescriptionId).HasMaxLength(256);

                entity.Property(e => e.FilmName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");
            });

            modelBuilder.Entity<FilmsToActor>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Actors)
                    .WithMany()
                    .HasForeignKey(d => d.ActorsId)
                    .HasConstraintName("FK__FilmsToAc__Actor__44FF419A");

                entity.HasOne(d => d.Film)
                    .WithMany()
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__FilmsToAc__FilmI__440B1D61");
            });

            modelBuilder.Entity<FilmsToGenre>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Film)
                    .WithMany()
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__FilmsToGe__FilmI__412EB0B6");

                entity.HasOne(d => d.Genre)
                    .WithMany()
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__FilmsToGe__Genre__4222D4EF");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.Rating1).HasColumnName("Rating");

                entity.Property(e => e.TextRating)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK__Ratings__FilmId__3A81B327");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Ratings__UserId__3B75D760");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
