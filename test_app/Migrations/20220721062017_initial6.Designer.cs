﻿// <auto-generated />
using System;
using E_commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace test_app.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20220721062017_initial6")]
    partial class initial6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_commerce.Models.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("StartPrice")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_Auctions_ProductID")
                        .IsUnique();

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("E_commerce.Models.AuctionsUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("AuctionId")
                        .HasColumnType("int")
                        .HasColumnName("AuctionID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex(new[] { "AuctionId" }, "IX_AuctionsUsers_AuctionID")
                        .HasDatabaseName("IX_AuctionsUsers_AuctionID1");

                    b.HasIndex(new[] { "UserId" }, "IX_AuctionsUsers_UserID")
                        .HasDatabaseName("IX_AuctionsUsers_UserID1");

                    b.ToTable("AuctionsUsers");
                });

            modelBuilder.Entity("E_commerce.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_at");

                    b.Property<int?>("CreatedByUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("E_commerce.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_Comments_ProductID");

                    b.HasIndex(new[] { "UserId" }, "IX_Comments_UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("E_commerce.Models.Help", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneId")
                        .HasColumnType("int")
                        .HasColumnName("PhoneID");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PhoneId" }, "IX_Helps_PhoneID");

                    b.ToTable("Helps");
                });

            modelBuilder.Entity("E_commerce.Models.ImagesProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_ImagesProduct_ProductID");

                    b.ToTable("ImagesProduct");
                });

            modelBuilder.Entity("E_commerce.Models.ImagesUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userID");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_ImagesUser_userID");

                    b.ToTable("ImagesUser");
                });

            modelBuilder.Entity("E_commerce.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_at");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PurchaseId")
                        .HasColumnType("int")
                        .HasColumnName("PurchaseID");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PurchaseId" }, "IX_Payments_PurchaseID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("E_commerce.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("E_commerce.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("E_commerce.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlaceId")
                        .HasColumnType("int")
                        .HasColumnName("PlaceID");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PlaceId" }, "IX_Places_PlaceID");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_at");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DetailsAr")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DetailsAR");

                    b.Property<string>("DetailsEn")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DetailsEN");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Evaluation")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NameAR");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NameEN");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Report")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CategoryId" }, "IX_Products_CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_commerce.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_at");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ExtraAmount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex(new[] { "ProductId" }, "IX_Purchases_ProductID")
                        .HasDatabaseName("IX_Purchases_ProductID1");

                    b.HasIndex(new[] { "UserId" }, "IX_Purchases_UserID")
                        .HasDatabaseName("IX_Purchases_UserID1");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("E_commerce.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PermissionsId")
                        .HasColumnType("int")
                        .HasColumnName("PermissionsID");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PermissionsId" }, "IX_Roles_PermissionsID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("E_commerce.Models.RolesUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int")
                        .HasColumnName("RolesID");

                    b.Property<int>("UsersId")
                        .HasColumnType("int")
                        .HasColumnName("UsersID");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex(new[] { "UsersId" }, "IX_RolesUsers_UsersID");

                    b.ToTable("RolesUsers");
                });

            modelBuilder.Entity("E_commerce.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneId")
                        .HasColumnType("int")
                        .HasColumnName("PhoneID");

                    b.Property<int?>("PlaceId")
                        .HasColumnType("int")
                        .HasColumnName("PlaceID");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserStatusId")
                        .HasColumnType("int")
                        .HasColumnName("UserStatusID");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int")
                        .HasColumnName("UsersID");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PhoneId" }, "IX_Users_PhoneID")
                        .IsUnique();

                    b.HasIndex(new[] { "PlaceId" }, "IX_Users_PlaceID");

                    b.HasIndex(new[] { "UserStatusId" }, "IX_Users_UserStatusID");

                    b.HasIndex(new[] { "UsersId" }, "IX_Users_UsersID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_commerce.Models.UserStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserStatus");
                });

            modelBuilder.Entity("test_app.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("E_commerce.Models.Auction", b =>
                {
                    b.HasOne("E_commerce.Models.Product", "Product")
                        .WithOne("Auction")
                        .HasForeignKey("E_commerce.Models.Auction", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_commerce.Models.AuctionsUser", b =>
                {
                    b.HasOne("E_commerce.Models.Auction", "Auction")
                        .WithOne("AuctionsUser")
                        .HasForeignKey("E_commerce.Models.AuctionsUser", "AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_commerce.Models.User", "User")
                        .WithOne("AuctionsUser")
                        .HasForeignKey("E_commerce.Models.AuctionsUser", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce.Models.Category", b =>
                {
                    b.HasOne("E_commerce.Models.Category", "CategoryNavigation")
                        .WithMany("InverseCategoryNavigation")
                        .HasForeignKey("CreatedByUserID");

                    b.Navigation("CategoryNavigation");
                });

            modelBuilder.Entity("E_commerce.Models.Comment", b =>
                {
                    b.HasOne("E_commerce.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId");

                    b.HasOne("E_commerce.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce.Models.Help", b =>
                {
                    b.HasOne("E_commerce.Models.Phone", "Phone")
                        .WithMany("Helps")
                        .HasForeignKey("PhoneId");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("E_commerce.Models.ImagesProduct", b =>
                {
                    b.HasOne("E_commerce.Models.Product", "Product")
                        .WithMany("ImagesProducts")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_commerce.Models.ImagesUser", b =>
                {
                    b.HasOne("E_commerce.Models.User", "User")
                        .WithMany("ImagesUsers")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce.Models.Payment", b =>
                {
                    b.HasOne("E_commerce.Models.Purchase", "Purchase")
                        .WithMany("Payments")
                        .HasForeignKey("PurchaseId");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("E_commerce.Models.Place", b =>
                {
                    b.HasOne("E_commerce.Models.Place", "PlaceNavigation")
                        .WithMany("InversePlaceNavigation")
                        .HasForeignKey("PlaceId");

                    b.Navigation("PlaceNavigation");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.HasOne("E_commerce.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_commerce.Models.Purchase", b =>
                {
                    b.HasOne("E_commerce.Models.Product", "Product")
                        .WithOne("Purchase")
                        .HasForeignKey("E_commerce.Models.Purchase", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_commerce.Models.User", "User")
                        .WithOne("Purchase")
                        .HasForeignKey("E_commerce.Models.Purchase", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce.Models.Role", b =>
                {
                    b.HasOne("E_commerce.Models.Permission", "Permissions")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionsId");

                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("E_commerce.Models.RolesUser", b =>
                {
                    b.HasOne("E_commerce.Models.Role", "Roles")
                        .WithMany("RolesUsers")
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_commerce.Models.User", "Users")
                        .WithMany("RolesUsers")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("E_commerce.Models.User", b =>
                {
                    b.HasOne("E_commerce.Models.Phone", "Phone")
                        .WithOne("User")
                        .HasForeignKey("E_commerce.Models.User", "PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_commerce.Models.Place", "Place")
                        .WithMany("Users")
                        .HasForeignKey("PlaceId");

                    b.HasOne("E_commerce.Models.UserStatus", "UserStatus")
                        .WithMany("Users")
                        .HasForeignKey("UserStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_commerce.Models.User", "Users")
                        .WithMany("InverseUsers")
                        .HasForeignKey("UsersId");

                    b.Navigation("Phone");

                    b.Navigation("Place");

                    b.Navigation("Users");

                    b.Navigation("UserStatus");
                });

            modelBuilder.Entity("E_commerce.Models.Auction", b =>
                {
                    b.Navigation("AuctionsUser");
                });

            modelBuilder.Entity("E_commerce.Models.Category", b =>
                {
                    b.Navigation("InverseCategoryNavigation");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_commerce.Models.Permission", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("E_commerce.Models.Phone", b =>
                {
                    b.Navigation("Helps");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_commerce.Models.Place", b =>
                {
                    b.Navigation("InversePlaceNavigation");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("E_commerce.Models.Product", b =>
                {
                    b.Navigation("Auction");

                    b.Navigation("Comments");

                    b.Navigation("ImagesProducts");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("E_commerce.Models.Purchase", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("E_commerce.Models.Role", b =>
                {
                    b.Navigation("RolesUsers");
                });

            modelBuilder.Entity("E_commerce.Models.User", b =>
                {
                    b.Navigation("AuctionsUser");

                    b.Navigation("Comments");

                    b.Navigation("ImagesUsers");

                    b.Navigation("InverseUsers");

                    b.Navigation("Purchase");

                    b.Navigation("RolesUsers");
                });

            modelBuilder.Entity("E_commerce.Models.UserStatus", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
