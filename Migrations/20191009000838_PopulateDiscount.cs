using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace Northwind.Migrations
{
    public partial class PopulateDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = System.IO.Path.Combine
                (System.AppDomain.CurrentDomain.BaseDirectory, "../../../", "Migrations", "SQL", @"Populate_Discounts.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
