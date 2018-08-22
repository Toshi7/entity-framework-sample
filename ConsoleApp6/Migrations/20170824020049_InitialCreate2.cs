using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TestingDb.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KeihiMeisais",
                table: "KeihiMeisais");

            migrationBuilder.RenameTable(
                name: "KeihiMeisais",
                newName: "Testing_KeihiDetail");

            migrationBuilder.RenameColumn(
                name: "KeihiDetailId",
                table: "Testing_KeihiDetail",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Testing_KeihiDetail",
                type: "varchar(10)",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "KeihiDetail_ID",
                table: "Testing_KeihiDetail",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "KeihiDetail_ID",
                table: "Testing_KeihiDetail");

            migrationBuilder.RenameTable(
                name: "Testing_KeihiDetail",
                newName: "KeihiMeisais");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "KeihiMeisais",
                newName: "KeihiDetailId");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "KeihiMeisais",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KeihiMeisais",
                table: "KeihiMeisais",
                column: "KeihiDetailId");
        }
    }
}
