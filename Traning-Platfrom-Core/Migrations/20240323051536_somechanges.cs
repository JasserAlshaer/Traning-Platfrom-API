using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traning_Platfrom_Core.Migrations
{
    /// <inheritdoc />
    public partial class somechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(6763),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 310, DateTimeKind.Local).AddTicks(2378),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(1258),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(6033),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(2719),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(435),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(7584),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.AlterColumn<string>(
                name: "Skills",
                table: "JobOpportunities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Responsability",
                table: "JobOpportunities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "JobOpportunities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "OtherApplicationCondition",
                table: "JobOpportunities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<float>(
                name: "MinGPA",
                table: "JobOpportunities",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "MinAmountOfSkills",
                table: "JobOpportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "JobPrivileges",
                table: "JobOpportunities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<int>(
                name: "JobApplicationStatus",
                table: "JobOpportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsMustHaveDrivingLicense",
                table: "JobOpportunities",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "ExperienceCount",
                table: "JobOpportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(9800),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 310, DateTimeKind.Local).AddTicks(1519),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(1998),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 310, DateTimeKind.Local).AddTicks(596),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(9618),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(8786),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(9303));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(4968),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "UserRoles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(6836),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Testimonials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(5575),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 310, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Skills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(2251),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Roles",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(5961),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Organizations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(4747),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "OrganizationAdmins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(5740),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekerSkills",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(1272),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobSeekers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(7875),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.AlterColumn<string>(
                name: "Skills",
                table: "JobOpportunities",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Responsability",
                table: "JobOpportunities",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "JobOpportunities",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherApplicationCondition",
                table: "JobOpportunities",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "MinGPA",
                table: "JobOpportunities",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MinAmountOfSkills",
                table: "JobOpportunities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobPrivileges",
                table: "JobOpportunities",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobApplicationStatus",
                table: "JobOpportunities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMustHaveDrivingLicense",
                table: "JobOpportunities",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExperienceCount",
                table: "JobOpportunities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobOpportunities",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(2374),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobInterviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(4552),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 310, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobFields",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 309, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JobApplications",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 44, DateTimeKind.Local).AddTicks(3449),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 310, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Experiences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 43, DateTimeKind.Local).AddTicks(284),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "EducationHistories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 22, 21, 58, 59, 42, DateTimeKind.Local).AddTicks(9303),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 3, 23, 8, 15, 36, 308, DateTimeKind.Local).AddTicks(8786));
        }
    }
}
