using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrystalClarityEyewearWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updateDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_PaymentMethods_PaymentId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostCategories_CatPostId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId1",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CatId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Order_OrderId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrderId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Products_CatId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CatPostId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Order_PaymentId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ParentId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsHomeFlag",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SaleDiscount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitInStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CatPostId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsHot",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsNewfeed",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsPublish",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ShortContent",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IsPublish",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Levels",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Ordering",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Posts",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Order",
                newName: "PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Categories",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "SeoTitle");

            migrationBuilder.RenameColumn(
                name: "CatId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsPublish",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsBestSeller",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatture",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHome",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHot",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSale",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSale",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SeoDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoKeywords",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoTitle",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SeoDescription",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoKeywords",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoTitle",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SeoDescription",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoKeywords",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "Categories",
                type: "int",
                maxLength: 200,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    IsRead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subcribe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcribe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemSetting",
                columns: table => new
                {
                    SettingKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    SettingDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSetting", x => x.SettingKey);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentMethodId",
                table: "Order",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_PaymentMethods_PaymentMethodId",
                table: "Order",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_PaymentMethods_PaymentMethodId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Subcribe");

            migrationBuilder.DropTable(
                name: "SystemSetting");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Order_PaymentMethodId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsFeatture",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsHome",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsHot",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsSale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceSale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoKeywords",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoTitle",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SeoDescription",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SeoKeywords",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SeoTitle",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SeoDescription",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SeoKeywords",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Posts",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodId",
                table: "Order",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "SeoTitle",
                table: "Category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Category",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "CatId");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPublish",
                table: "Products",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsBestSeller",
                table: "Products",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "IsHomeFlag",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SaleDiscount",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitInStock",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "CatPostId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHot",
                table: "Posts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNewfeed",
                table: "Posts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                table: "Posts",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortContent",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "OrderDetail",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "OrderDetail",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Order",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Order",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Order",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                table: "Category",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Levels",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ordering",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CatId");

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrderId",
                table: "Users",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatId",
                table: "Products",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CatPostId",
                table: "Posts",
                column: "CatPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId1",
                table: "Posts",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentId",
                table: "Order",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Category",
                column: "ParentId",
                principalTable: "Category",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_PaymentMethods_PaymentId",
                table: "Order",
                column: "PaymentId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostCategories_CatPostId",
                table: "Posts",
                column: "CatPostId",
                principalTable: "PostCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId1",
                table: "Posts",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CatId",
                table: "Products",
                column: "CatId",
                principalTable: "Category",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Order_OrderId",
                table: "Users",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }
    }
}
