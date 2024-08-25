using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShassiWPFApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Harness_drawing",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Harness = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Harness_version = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Drawing = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Drawing_version = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harness_drawing", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Harness_wires",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Harness_ID = table.Column<int>(type: "integer", nullable: false),
                    Length = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Color = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Housing_1 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Housing_2 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harness_wires", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Harness_wires_Harness_drawing_Harness_ID",
                        column: x => x.Harness_ID,
                        principalTable: "Harness_drawing",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Harness_drawing",
                columns: new[] { "ID", "Drawing", "Drawing_version", "Harness", "Harness_version" },
                values: new object[,]
                {
                    { 38643, "EP", "S-4", "S2656843M", "5" },
                    { 39077, "EP", "S-4", "S2641137M", "S-9" },
                    { 39087, "EP", "S-4", "S2563549M", "S-9" },
                    { 40442, "EP", "S-4", "S2563545M", "S12" },
                    { 40953, "EP", "S-4", "S2563532M", "S-6" }
                });

            migrationBuilder.InsertData(
                table: "Harness_wires",
                columns: new[] { "ID", "Color", "Harness_ID", "Housing_1", "Housing_2", "Length" },
                values: new object[,]
                {
                    { 3115654, "R", 38643, "C604:19", "P2.BX2:1", "950" },
                    { 3115655, "R", 38643, "C604:23", "C521:1", "450" },
                    { 3158749, "BN", 39077, "E71.B:1", "C604:21", "665" },
                    { 3158750, "GR", 39077, "E71.B:4", "C604:23", "665" },
                    { 3159894, "W", 39087, "E71.A:1", "C681", "465" },
                    { 3159895, "SB", 39087, "E71.P:3", "G504-2", "680" },
                    { 3277678, "GN", 40442, "P2.E85:1", "C680", "475" },
                    { 3277679, "R", 40442, "P2.BX2:1", "E30.P:1", "980" },
                    { 3328453, "W", 40953, "C621:6", "C681", "365" },
                    { 3328454, "SB", 40953, "C620:24", "G508-3", "305" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Harness_drawing_ID",
                table: "Harness_drawing",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Harness_wires_Harness_ID",
                table: "Harness_wires",
                column: "Harness_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Harness_wires_ID",
                table: "Harness_wires",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Harness_wires");

            migrationBuilder.DropTable(
                name: "Harness_drawing");
        }
    }
}
