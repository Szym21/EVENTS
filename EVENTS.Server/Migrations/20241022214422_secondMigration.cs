using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsAPI.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EVENT_TYPE",
                schema: "Events",
                table: "Event",
                newName: "EVENT_TYPE_ID");

            migrationBuilder.AddColumn<int>(
                name: "EVENTID",
                schema: "Events",
                table: "EventUser",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "USERID",
                schema: "Events",
                table: "EventUser",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EVENT_TYPEID",
                schema: "Events",
                table: "Event",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_EVENTID",
                schema: "Events",
                table: "EventUser",
                column: "EVENTID");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_USERID",
                schema: "Events",
                table: "EventUser",
                column: "USERID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EVENT_TYPEID",
                schema: "Events",
                table: "Event",
                column: "EVENT_TYPEID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_EventType_EVENT_TYPEID",
                schema: "Events",
                table: "Event",
                column: "EVENT_TYPEID",
                principalSchema: "Events",
                principalTable: "EventType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventUser_Event_EVENTID",
                schema: "Events",
                table: "EventUser",
                column: "EVENTID",
                principalSchema: "Events",
                principalTable: "Event",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventUser_User_USERID",
                schema: "Events",
                table: "EventUser",
                column: "USERID",
                principalSchema: "Events",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_EventType_EVENT_TYPEID",
                schema: "Events",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_EventUser_Event_EVENTID",
                schema: "Events",
                table: "EventUser");

            migrationBuilder.DropForeignKey(
                name: "FK_EventUser_User_USERID",
                schema: "Events",
                table: "EventUser");

            migrationBuilder.DropIndex(
                name: "IX_EventUser_EVENTID",
                schema: "Events",
                table: "EventUser");

            migrationBuilder.DropIndex(
                name: "IX_EventUser_USERID",
                schema: "Events",
                table: "EventUser");

            migrationBuilder.DropIndex(
                name: "IX_Event_EVENT_TYPEID",
                schema: "Events",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EVENTID",
                schema: "Events",
                table: "EventUser");

            migrationBuilder.DropColumn(
                name: "USERID",
                schema: "Events",
                table: "EventUser");

            migrationBuilder.DropColumn(
                name: "EVENT_TYPEID",
                schema: "Events",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "EVENT_TYPE_ID",
                schema: "Events",
                table: "Event",
                newName: "EVENT_TYPE");
        }
    }
}
