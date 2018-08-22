using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TestingDb.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "KeihiDetail_ID",
                table: "Testing_KeihiDetail");

            migrationBuilder.AddPrimaryKey(
                name: "KeihiDetail_Id",
                table: "Testing_KeihiDetail",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "KeihiDetail_Id",
                table: "Testing_KeihiDetail");

            migrationBuilder.AddPrimaryKey(
                name: "KeihiDetail_ID",
                table: "Testing_KeihiDetail",
                column: "ID");
        }
    }
}
