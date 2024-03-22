using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traning_Platfrom_Core.Migrations
{
    /// <inheritdoc />
    public partial class editProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(7080),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8892),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(6189),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 779, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4172),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8057),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(5820),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(6784),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(3210),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(9890),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "FaceBook",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Github",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Instgram",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Lanaguage",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(3182),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(5207),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4998),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(2226),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(1279),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(4376));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "FaceBook",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Github",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Instgram",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Lanaguage",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "JobSeekers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(242),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(2049),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 779, DateTimeKind.Local).AddTicks(211),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(7606),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(9731),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(6410),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(3052),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(7225),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(9249),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(8585),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 778, DateTimeKind.Local).AddTicks(8158),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(5327),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 6, 42, 777, DateTimeKind.Local).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(1279));
        }
    }
}
