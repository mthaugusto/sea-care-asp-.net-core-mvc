using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_sea_care.Migrations
{
    /// <inheritdoc />
    public partial class updateusuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DT_FIM",
                table: "TB_PARCEIROS",
                type: "NVARCHAR2(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DT_FIM",
                table: "TB_PARCEIROS",
                type: "NVARCHAR2(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(10)",
                oldNullable: true);
        }
    }
}
