using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUTH_SERVICE_INFRASTRUCTURE.Migrations
{
    public partial class AlterTableLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "type",
                table: "Log",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "log_time",
                table: "Log",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 22, 17, 50, 51, 550, DateTimeKind.Local).AddTicks(6530),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 2, 22, 17, 37, 13, 523, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.AddColumn<string>(
                name: "type_name",
                table: "Log",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_name",
                table: "Log");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "Log",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "log_time",
                table: "Log",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 22, 17, 37, 13, 523, DateTimeKind.Local).AddTicks(926),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2022, 2, 22, 17, 50, 51, 550, DateTimeKind.Local).AddTicks(6530));
        }
    }
}
