using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FingerPrintDataAcessLayer.Migrations
{
    public partial class addtodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fingerprints",
                columns: table => new
                {
                    FingerPrintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorCode = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageWidth = table.Column<int>(type: "int", nullable: false),
                    ImageHeight = table.Column<int>(type: "int", nullable: false),
                    ImageDPI = table.Column<int>(type: "int", nullable: false),
                    ImageQuality = table.Column<int>(type: "int", nullable: false),
                    ImageNFIQ = table.Column<int>(type: "int", nullable: false),
                    ImageDataBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BMPBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WSQImageSize = table.Column<int>(type: "int", nullable: false),
                    WSQImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fingerprints", x => x.FingerPrintId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fingerprints");
        }
    }
}
