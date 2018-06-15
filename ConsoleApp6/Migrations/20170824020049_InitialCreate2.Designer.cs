using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestingDb;

namespace TestingDb.Migrations
{
    [DbContext(typeof(KeihiContext))]
    [Migration("20170824020049_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("TestingDb.Testing_KeihiDetail", b =>
                {
                    b.Property<int>("KeihiDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Dt");

                    b.Property<string>("Payee");

                    b.Property<string>("Remark");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Subject")
                        .HasColumnType("varchar(10)")
                        .HasDefaultValueSql("''");

                    b.HasKey("KeihiDetailId")
                        .HasName("KeihiDetail_ID");

                    b.ToTable("Testing_KeihiDetail");
                });
        }
    }
}
