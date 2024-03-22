using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traning_Platfrom_Core.Migrations
{
    /// <inheritdoc />
    public partial class qualificatin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 148, DateTimeKind.Local).AddTicks(6988),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 148, DateTimeKind.Local).AddTicks(8965),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 150, DateTimeKind.Local).AddTicks(7266),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 596, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(4571),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 148, DateTimeKind.Local).AddTicks(8045),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(6372),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(7380),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(3548),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(4),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.AddColumn<int>(
                name: "Qualification",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(8285),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 150, DateTimeKind.Local).AddTicks(361),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(5481),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(9338),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(1427),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(5392));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "JobSeekers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(1029),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 148, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2933),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 148, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 596, DateTimeKind.Local).AddTicks(1365),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 150, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(8305),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2059),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 148, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(966),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(7330),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(3984),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(7493),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(9894),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 150, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9145),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(8536),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(6372),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(5392),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 15, 18, 23, 149, DateTimeKind.Local).AddTicks(1427));
        }
    }
}
