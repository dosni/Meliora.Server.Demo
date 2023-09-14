using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FUIServerSample.Layer.DataLayer.Migrations
{
    public partial class InitMigraion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    Postal_Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    Country = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cust_Type = table.Column<string>(type: "char(1)", nullable: false),
                    Cellular = table.Column<string>(type: "varchar(15)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Tax_Id = table.Column<string>(type: "varchar(20)", nullable: false),
                    SSN = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Cellular", "City", "Country", "Cust_Type", "Email", "FirstName", "LastName", "Phone", "Postal_Code", "SSN", "Tax_Id" },
                values: new object[] { 1, "", "", "Berlin", "Germany", "", "", "Maria", "Anders", "030-0074321", "", "", "" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Cellular", "City", "Country", "Cust_Type", "Email", "FirstName", "LastName", "Phone", "Postal_Code", "SSN", "Tax_Id" },
                values: new object[] { 2, "", "", "México D.F.", "México", "", "", "Ana", "Trujillo", "(5) 555-4729", "", "", "" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Cellular", "City", "Country", "Cust_Type", "Email", "FirstName", "LastName", "Phone", "Postal_Code", "SSN", "Tax_Id" },
                values: new object[] { 3, "", "", "México D.F.", "México", "", "", "Antonio", "Moreno", "(5) 555-3932", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
