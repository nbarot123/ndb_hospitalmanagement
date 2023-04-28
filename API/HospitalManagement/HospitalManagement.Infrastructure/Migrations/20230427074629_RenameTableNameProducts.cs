using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Infrastructure.Migrations
{
    public partial class RenameTableNameProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
            name: "Products",
            schema: "dbo",
            newName: "TblProducts",
            newSchema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
            name: "TblProducts",
            schema: "dbo",
            newName: "Products",
            newSchema: "dbo");

        }
    }
}
