using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4NewsApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublishTime = table.Column<DateTime>(nullable: false),
                    Heading = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Body", "Heading", "PublishTime" },
                values: new object[,]
                {
                    { 1L, "Last night a UFO was spotted flying over the city.", "UFO spotted", new DateTime(2018, 9, 28, 12, 57, 8, 688, DateTimeKind.Utc) },
                    { 2L, "A lecturer was sentenced to prison as their lectures were so boring students died.", "Lecturer sentenced to prison", new DateTime(2018, 9, 29, 12, 57, 8, 688, DateTimeKind.Utc) },
                    { 3L, "Yesterday officials recorded a record +22 degrees Celcius in Helsinki, Finland. It is the hottest summer Finland has seen in decades.", "Finland: new temperature record", new DateTime(2018, 9, 30, 12, 57, 8, 688, DateTimeKind.Utc) },
                    { 4L, "Literally, absolutely nothing worth writing news about occurred today.", "Nothing interesting happened today", new DateTime(2018, 10, 1, 12, 57, 8, 688, DateTimeKind.Utc) },
                    { 5L, "For completely unknown reasons, it seems the Finnish national railways have problems every season. In the winter it is the snow and ice. In the autumn it is the falling leaves. In the spring and summer it is for no apparent reason.", "The four seasons for Finnish national railways", new DateTime(2018, 10, 2, 12, 57, 8, 688, DateTimeKind.Utc) },
                    { 6L, "This is just a test. Please ignore.", "Test news", new DateTime(2018, 10, 3, 12, 57, 8, 688, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
