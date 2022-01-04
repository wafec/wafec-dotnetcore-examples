using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlServerMigrationsContext1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Context1");

            migrationBuilder.CreateTable(
                name: "Entity1s",
                schema: "Context1",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entity2s",
                schema: "Context1",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entity1Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity2s_Entity1s_Entity1Id",
                        column: x => x.Entity1Id,
                        principalSchema: "Context1",
                        principalTable: "Entity1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entity2s_Entity1Id",
                schema: "Context1",
                table: "Entity2s",
                column: "Entity1Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entity2s",
                schema: "Context1");

            migrationBuilder.DropTable(
                name: "Entity1s",
                schema: "Context1");
        }
    }
}
