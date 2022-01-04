using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlServerMigrationsContext2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Context2");

            migrationBuilder.CreateTable(
                name: "Entity1s",
                schema: "Context2",
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
                schema: "Context2",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entity1Id = table.Column<long>(type: "bigint", nullable: true),
                    Context1Entity1Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity2s_Entity1s_Context1Entity1Id",
                        column: x => x.Context1Entity1Id,
                        principalSchema: "Context1",
                        principalTable: "Entity1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entity2s_Entity1s_Entity1Id",
                        column: x => x.Entity1Id,
                        principalSchema: "Context2",
                        principalTable: "Entity1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entity2s_Context1Entity1Id",
                schema: "Context2",
                table: "Entity2s",
                column: "Context1Entity1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Entity2s_Entity1Id",
                schema: "Context2",
                table: "Entity2s",
                column: "Entity1Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entity2s",
                schema: "Context2");

            migrationBuilder.DropTable(
                name: "Entity1s",
                schema: "Context2");
        }
    }
}
