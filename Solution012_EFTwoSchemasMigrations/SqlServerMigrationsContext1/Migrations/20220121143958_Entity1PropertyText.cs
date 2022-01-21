using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlServerMigrationsContext1.Migrations
{
    public partial class Entity1PropertyText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                schema: "Context1",
                table: "Entity1s",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                schema: "Context1",
                table: "Entity1s");
        }
    }
}
