using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCNH.Migrations
{
    public partial class Primermigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piezas",
                columns: table => new
                {
                    PiezaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PiezaNombre = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PiezaMedida = table.Column<double>(type: "float", nullable: false),
                    PiezaDescripcion = table.Column<string>(type: "nvarchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piezas", x => x.PiezaId);
                });

            migrationBuilder.CreateTable(
                name: "Mediciones",
                columns: table => new
                {
                    MedicionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicion = table.Column<double>(type: "float", nullable: false),
                    MedicionDescripcion = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    PiezaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mediciones", x => x.MedicionId);
                    table.ForeignKey(
                        name: "FK_Mediciones_Piezas_PiezaId",
                        column: x => x.PiezaId,
                        principalTable: "Piezas",
                        principalColumn: "PiezaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Piezas",
                columns: new[] { "PiezaId", "PiezaDescripcion", "PiezaMedida", "PiezaNombre" },
                values: new object[,]
                {
                    { 1, "Freno descripcion 140mm", 140.0, "Freno disco 140mm" },
                    { 2, "Freno descripcion 150mm", 150.0, "Freno disco 150mm" },
                    { 3, "Freno descripcion 160mm", 160.0, "Freno disco 160mm" },
                    { 4, "Freno descripcion 170mm", 170.0, "Freno disco 170mm" }
                });

            migrationBuilder.InsertData(
                table: "Mediciones",
                columns: new[] { "MedicionId", "Medicion", "MedicionDescripcion", "PiezaId" },
                values: new object[,]
                {
                    { 1L, 140.5, "Descripcion 1", 1 },
                    { 23L, 160.5, "Descripcion 23", 3 },
                    { 24L, 160.30000000000001, "Descripcion 24", 3 },
                    { 25L, 160.09999999999999, "Descripcion 25", 3 },
                    { 26L, 160.30000000000001, "Descripcion 26", 3 },
                    { 27L, 159.59999999999999, "Descripcion 27", 3 },
                    { 28L, 160.19999999999999, "Descripcion 28", 3 },
                    { 29L, 160.09999999999999, "Descripcion 29", 3 },
                    { 22L, 160.40000000000001, "Descripcion 22", 3 },
                    { 30L, 159.80000000000001, "Descripcion 30", 3 },
                    { 32L, 170.40000000000001, "Descripcion 32", 4 },
                    { 33L, 170.5, "Descripcion 33", 4 },
                    { 34L, 170.30000000000001, "Descripcion 34", 4 },
                    { 35L, 170.09999999999999, "Descripcion 35", 4 },
                    { 36L, 170.30000000000001, "Descripcion 36", 4 },
                    { 37L, 169.59999999999999, "Descripcion 37", 4 },
                    { 38L, 170.19999999999999, "Descripcion 38", 4 },
                    { 31L, 170.09999999999999, "Descripcion 31", 4 },
                    { 21L, 160.09999999999999, "Descripcion 21", 3 },
                    { 20L, 149.90000000000001, "Descripcion 20", 2 },
                    { 19L, 149.80000000000001, "Descripcion 19", 2 },
                    { 2L, 140.30000000000001, "Descripcion 2", 1 },
                    { 3L, 140.09999999999999, "Descripcion 3", 1 },
                    { 4L, 140.30000000000001, "Descripcion 4", 1 },
                    { 5L, 139.59999999999999, "Descripcion 5", 1 },
                    { 6L, 140.19999999999999, "Descripcion 6", 1 },
                    { 7L, 140.09999999999999, "Descripcion 7", 1 },
                    { 8L, 139.80000000000001, "Descripcion 8", 1 },
                    { 9L, 139.90000000000001, "Descripcion 9", 1 },
                    { 10L, 140.09999999999999, "Descripcion 10", 1 },
                    { 11L, 150.40000000000001, "Descripcion 11", 2 },
                    { 12L, 150.5, "Descripcion 12", 2 },
                    { 13L, 150.30000000000001, "Descripcion 13", 2 },
                    { 14L, 150.09999999999999, "Descripcion 14", 2 },
                    { 15L, 150.30000000000001, "Descripcion 15", 2 },
                    { 16L, 149.59999999999999, "Descripcion 16", 2 },
                    { 17L, 150.19999999999999, "Descripcion 17", 2 },
                    { 18L, 150.09999999999999, "Descripcion 18", 2 },
                    { 39L, 170.09999999999999, "Descripcion 39", 4 },
                    { 40L, 169.80000000000001, "Descripcion 40", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mediciones_PiezaId",
                table: "Mediciones",
                column: "PiezaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mediciones");

            migrationBuilder.DropTable(
                name: "Piezas");
        }
    }
}
