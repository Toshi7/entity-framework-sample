using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestingDb;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TestingDb.Migrations
{
    [DbContext(typeof(KeihiContext))]
    [Migration("20170824020614_InitialCreate3")]
    partial class InitialCreate3
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
                        .HasName("KeihiDetail_Id");

                    b.ToTable("Testing_KeihiDetail");
                });
        }
    }
}
