using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.VisualBasic;

namespace ContactManager.Migrations
{
    public partial class Step10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.UpdateData(
            //    table: "Contacts",
            //    keyColumn: "ContactId",
            //    keyValue: 1,
            //    column: "DateAdded",
            //    value: new DateTime(2020, 9, 24, 16, 40, 29, 376, DateTimeKind.Local).AddTicks(420));

            //migrationBuilder.UpdateData(
            //    table: "Contacts",
            //    keyColumn: "ContactId",
            //    keyValue: 2,
            //    column: "DateAdded",
            //    value: new DateTime(2020, 9, 24, 16, 40, 29, 378, DateTimeKind.Local).AddTicks(9342));

            //migrationBuilder.UpdateData(
            //    table: "Contacts",
            //    keyColumn: "ContactId",
            //    keyValue: 3,
            //    column: "DateAdded",
            //    value: new DateTime(2020, 9, 24, 16, 40, 29, 378, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Firstname", "Lastname", "Phone", "Email", "CategoryId", "DateAdded" },
                values: new object[] { 4, "Alexander", "de Jongh", "035-533-7915", "ajongh@gmail.com", 2, new DateTime(2020, 9, 21, 16, 3, 2, 497, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: true),
                    ContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceId", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "IssueDate", "DueDate", "ContactId" },
                values: new object[] { 1, new DateTime(2020, 9, 21, 16, 3, 2, 497, DateTimeKind.Local).AddTicks(1496), new DateTime(2020, 10, 15, 16, 3, 2, 497, DateTimeKind.Local).AddTicks(1496) , 4});

            migrationBuilder.InsertData(
               table: "Invoices",
               columns: new[] { "InvoiceId", "IssueDate", "DueDate", "ContactId" },
               values: new object[] { 2, new DateTime(2020, 9, 21, 16, 3, 2, 497, DateTimeKind.Local).AddTicks(1496), new DateTime(2020, 11, 22, 16, 3, 2, 497, DateTimeKind.Local).AddTicks(1496),  2});

        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.UpdateData(
            //    table: "Contacts",
            //    keyColumn: "ContactId",
            //    keyValue: 1,
            //    column: "DateAdded",
            //    value: new DateTime(2020, 9, 24, 16, 28, 48, 140, DateTimeKind.Local).AddTicks(1827));

            //migrationBuilder.UpdateData(
            //    table: "Contacts",
            //    keyColumn: "ContactId",
            //    keyValue: 2,
            //    column: "DateAdded",
            //    value: new DateTime(2020, 9, 24, 16, 28, 48, 143, DateTimeKind.Local).AddTicks(199));

            //migrationBuilder.UpdateData(
            //    table: "Contacts",
            //    keyColumn: "ContactId",
            //    keyValue: 3,
            //    column: "DateAdded",
            //    value: new DateTime(2020, 9, 24, 16, 28, 48, 143, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
