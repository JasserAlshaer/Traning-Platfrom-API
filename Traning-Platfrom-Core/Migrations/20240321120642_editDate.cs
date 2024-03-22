using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Traning_Platfrom_Core.Migrations
{
    /// <inheritdoc />
    public partial class editDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(242),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(2049),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(7606),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(9731),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(6622));

            
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(6410),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(3052),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(7973));



            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(7225),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 983, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(9249),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 984, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(8585),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(4778));

            

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(8158),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 983, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(5327),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(9324));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOpportunities_JobFields_JobFieldId",
                table: "JobOpportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_JobFields_JobFieldId",
                table: "Organizations");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_JobFieldId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_JobOpportunities_JobFieldId",
                table: "JobOpportunities");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "JobFieldId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "JobFieldId",
                table: "JobOpportunities");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "JobFields");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(5129),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(6978),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(2131),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(6126),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(6622),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(8220),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(1207),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(7973),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 983, DateTimeKind.Local).AddTicks(8165),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 984, DateTimeKind.Local).AddTicks(542),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(4778),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 983, DateTimeKind.Local).AddTicks(9437),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 982, DateTimeKind.Local).AddTicks(242),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 11, 15, 40, 981, DateTimeKind.Local).AddTicks(9324),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(4376));
        }
    }
}
