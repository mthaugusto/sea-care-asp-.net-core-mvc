using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_sea_care.Migrations
{
    /// <inheritdoc />
    public partial class parceiroupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DT_FIM",
                table: "TB_PARCEIROS",
                type: "NVARCHAR2(10)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DT_FIM",
                table: "TB_PARCEIROS",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(10)");
        }
    }
}
