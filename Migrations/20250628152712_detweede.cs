using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace media_audio.Migrations
{
    /// <inheritdoc />
    public partial class detweede : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_CDS_CDDetailsId",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CDS",
                newName: "CDId");

            migrationBuilder.AlterColumn<int>(
                name: "CDDetailsId",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_CDS_CDDetailsId",
                table: "Tracks",
                column: "CDDetailsId",
                principalTable: "CDS",
                principalColumn: "CDId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_CDS_CDDetailsId",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "CDId",
                table: "CDS",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "CDDetailsId",
                table: "Tracks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_CDS_CDDetailsId",
                table: "Tracks",
                column: "CDDetailsId",
                principalTable: "CDS",
                principalColumn: "Id");
        }
    }
}
