using p1.core.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace p1.infrastructure.Data
{
    public partial class p1Context : DbContext
    {
        public p1Context()
        {
        }

        public p1Context(DbContextOptions<p1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Champion> Champion { get; set; }
        public virtual DbSet<ChampionUser> ChampionUser { get; set; }
        public virtual DbSet<Player> Player { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Champion>(entity =>
            {
                entity.Property(e => e.NameChampion)
                    .IsRequired()
                    .HasColumnName("Name_Champion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionUser>(entity =>
            {
                entity.HasKey(e => new { e.ChampionId, e.PlayerId })
                    .HasName("PK__Champion__B8B0146FE6420A34");

                entity.HasOne(d => d.Champion)
                    .WithMany(p => p.ChampionUser)
                    .HasForeignKey(d => d.ChampionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChampionU__Champ__3A81B327");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.ChampionUser)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChampionU__Playe__3B75D760");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.NamePlayer)
                    .IsRequired()
                    .HasColumnName("Name_Player")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });


        }


    }
}
