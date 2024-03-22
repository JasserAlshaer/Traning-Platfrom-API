using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traning_Platfrom_Core.Migrations
{
    /// <inheritdoc />
    public partial class resumes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(1029),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2933),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 596, DateTimeKind.Local).AddTicks(1365),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(8305),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2059),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(966),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(7330),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(3984),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatus",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "JobSeekers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(7493),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(9894),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9145),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(8536),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(6372),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(5392),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(1279));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "JobSeekers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(7080),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8892),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(6189),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 596, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4172),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(8057),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(5820),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(6784),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(3210),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 864, DateTimeKind.Local).AddTicks(9890),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(3182),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(5207),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(4998),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 866, DateTimeKind.Local).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 595, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(2226),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 0, 14, 52, 865, DateTimeKind.Local).AddTicks(1279),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 0, 26, 49, 594, DateTimeKind.Local).AddTicks(5392));
        }
    }
}
