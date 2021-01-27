using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Labb_3_SQL_2
{
    public partial class JosefPhilipBokHandelContext : DbContext
    {
        private static JosefPhilipBokHandelContext dbInstance;


        private JosefPhilipBokHandelContext()
        {
            
        }

        private JosefPhilipBokHandelContext(DbContextOptions<JosefPhilipBokHandelContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Butiker> Butikers { get; set; }
        public virtual DbSet<Böcker> Böckers { get; set; }
        public virtual DbSet<Författare> Författares { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Kunder> Kunders { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldos { get; set; }

        public static JosefPhilipBokHandelContext GetInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new JosefPhilipBokHandelContext();
            }
            return dbInstance;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.HasKey(e => e.ButikId);

                entity.ToTable("Butiker");

                entity.Property(e => e.ButikId)
                    .ValueGeneratedNever()
                    .HasColumnName("ButikID");

                entity.Property(e => e.Butikadress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Butiknamn)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn);

                entity.ToTable("Böcker");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(50)
                    .HasColumnName("ISBN");

                entity.Property(e => e.FörfattareId).HasColumnName("FörfattareID");

                entity.Property(e => e.Språk)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Utgivningsdatum).HasMaxLength(50);

                entity.HasOne(d => d.Författare)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.FörfattareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Böcker_Författare");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.Genre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Böcker_Genre");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.HasKey(e => e.Identitet);

                entity.ToTable("Författare");

                entity.Property(e => e.Identitet).ValueGeneratedNever();

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre");

                entity.Property(e => e.GenreId)
                    .ValueGeneratedNever()
                    .HasColumnName("GenreID");

                entity.Property(e => e.Genrenamn)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Kunder>(entity =>
            {
                entity.ToTable("Kunder");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Bok).HasMaxLength(50);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("E-Mail");

                entity.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SkickaMail).HasColumnName("Skicka Mail");

                entity.HasOne(d => d.BokNavigation)
                    .WithMany(p => p.Kunders)
                    .HasForeignKey(d => d.Bok)
                    .HasConstraintName("FK_Kunder_Böcker");

                entity.HasOne(d => d.ButikNavigation)
                    .WithMany(p => p.Kunders)
                    .HasForeignKey(d => d.Butik)
                    .HasConstraintName("FK_Kunder_Kunder");
            });

            modelBuilder.Entity<LagerSaldo>(entity =>
            {
                entity.HasKey(e => new { e.ButikId, e.Isbn });

                entity.ToTable("LagerSaldo");

                entity.Property(e => e.ButikId).HasColumnName("ButikID");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(50)
                    .HasColumnName("ISBN");

                entity.HasOne(d => d.Butik)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.ButikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LagerSaldo_Butiker");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LagerSaldo_Böcker");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
