using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_sea_care.Migrations
{
    /// <inheritdoc />
    public partial class updatingproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "VL_PRODUTO",
                table: "TB_PRODUTO",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "BINARY_DOUBLE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "VL_PRODUTO",
                table: "TB_PRODUTO",
                type: "BINARY_DOUBLE",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
