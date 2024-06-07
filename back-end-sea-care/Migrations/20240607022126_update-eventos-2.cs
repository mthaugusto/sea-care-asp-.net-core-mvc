using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_sea_care.Migrations
{
    /// <inheritdoc />
    public partial class updateeventos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MEDIA_AVALIACOES",
                table: "TB_EVENTO",
                type: "BINARY_DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "BINARY_DOUBLE");

            migrationBuilder.AlterColumn<string>(
                name: "FOTO",
                table: "TB_EVENTO",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<int>(
                name: "AVALIACAO",
                table: "TB_EVENTO",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MEDIA_AVALIACOES",
                table: "TB_EVENTO",
                type: "BINARY_DOUBLE",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "BINARY_DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FOTO",
                table: "TB_EVENTO",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AVALIACAO",
                table: "TB_EVENTO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);
        }
    }
}
