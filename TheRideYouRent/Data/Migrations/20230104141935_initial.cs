using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRideYouRent.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    car_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    make = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    body_type = table.Column<string>(nullable: true),
                    kilometers_travelled = table.Column<int>(nullable: false),
                    service_kilometers = table.Column<int>(nullable: false),
                    available = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.car_id);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    driver_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    cell_number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.driver_id);
                });

            migrationBuilder.CreateTable(
                name: "Inspector",
                columns: table => new
                {
                    inspector_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    cell_number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspector", x => x.inspector_id);
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                columns: table => new
                {
                    rental_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    driver_id = table.Column<int>(nullable: false),
                    inspector_id = table.Column<int>(nullable: false),
                    rental_fee = table.Column<int>(nullable: false),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.rental_id);
                });

            migrationBuilder.CreateTable(
                name: "Return",
                columns: table => new
                {
                    return_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rental_id = table.Column<int>(nullable: false),
                    return_date = table.Column<DateTime>(nullable: false),
                    fine = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return", x => x.return_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Inspector");

            migrationBuilder.DropTable(
                name: "Rental");

            migrationBuilder.DropTable(
                name: "Return");
        }
    }
}
