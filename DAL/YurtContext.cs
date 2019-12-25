using MODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class YurtContext : DbContext
    {
        public YurtContext() : base("cstr")
        {

        }
        
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Okul> Okuls { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");

            modelBuilder.Entity<Ogrenci>().Property(o => o.ad).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.soyad).HasMaxLength(75).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.anneAd).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.anneSoyad).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.babaAd).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.babaSoyad).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.okulId).IsRequired().HasColumnType("int");

            modelBuilder.Entity<Okul>().ToTable("tblOkul");

            modelBuilder.Entity<Okul>().Property(o => o.Okul_Ad).HasMaxLength(10).IsRequired().HasColumnType("varchar");








        }
    }
}
