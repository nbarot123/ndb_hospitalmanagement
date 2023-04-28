using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Infrastructure.Migrations
{
    public partial class AddUniqueConstraintToProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
            name: "UN_TblProducts_ProductId",
            schema: "dbo",
            table: "TblProducts",
            column: "ProductId");            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
            name: "UN_TblProducts_ProductId",
            schema: "dbo",
            table: "TblProducts");            
        }
    }
}
