using KeihiDetail.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestingDb
{
    public class KeihiContext : DbContext
    {
        // public DbSet<エンティティクラス名> テーブル名 { get; set; } としてプロパティ定義する
        public DbSet<Testing_KeihiDetail> KeihiMeisais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User Id=postgres;Password=;Host=localhost;Port=5432;Database=practice1");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Testing_KeihiDetail>(entity =>
            {
                //主キーを設定し、主キー制約名を.HasNameで設定している。
                //.HasKey複合主キー
               // entity.HasKey(e => e.KeihiDetailid)
               //      .HasName("KeihiDetail_Id");

                entity.ToTable("Testing_KeihiDetail");

//                entity.Property(e => e.Testing_KeihiDetailId).HasColumnName("andro");

                entity.Property(e => e.Subject)
                    .IsRequired(true)  
                    .HasColumnName("Subject")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

            });
        }
        }
}
