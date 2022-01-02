﻿// <auto-generated />
using System;
using CommercialSite.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CommercialSite.Model.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211004165949_UserBrandCategory")]
    partial class UserBrandCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CommercialSite.Model.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2cb8bfab-ff82-41bd-bf39-84d3e5b6ef89"),
                            BrandName = "ACER",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("af6273bb-dc30-4a61-9aeb-8225636f564a"),
                            BrandName = "Lenovo",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("076bff1f-6c72-4eca-9bf9-1fe491a108b4"),
                            BrandName = "Samsung",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("877bdb84-f2f3-4143-aae4-b1a5e6103781"),
                            BrandName = "Apple",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("ad3869c4-0631-4d56-8fc3-12b9afd7d40a"),
                            BrandName = "Xiaomi",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("14534656-c0d2-44cf-922c-6fc83a21c203"),
                            BrandName = "Oppo",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("6520d7be-be4d-4b0d-a222-7e3d90c42de1"),
                            BrandName = "Philips",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("1a7c509d-42e2-4213-a944-212f07222084"),
                            BrandName = "LG",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("e49c6a75-5835-471e-918a-3345bbb26809"),
                            BrandName = "Reeder",
                            Status = 1
                        });
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"),
                            CategoryName = "Bilgisayar",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("afa8a153-6eed-4ad2-a453-dc6d2f86caab"),
                            CategoryName = "Telefon",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("8d0de41d-191a-469f-8909-61c169df2d8e"),
                            CategoryName = "Tablet",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("21f8242e-dd3a-4280-85ad-3bce8bbe4c8c"),
                            CategoryName = "Televizyon",
                            Status = 1
                        });
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.CommentReaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductCommentId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("ProductCommentId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("CommentReactions");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<double?>("DiscountPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Rate")
                        .HasColumnType("integer");

                    b.Property<int?>("ReviewNumber")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.Property<double>("WithoutDiscountPrice")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int?>("ThumbDown")
                        .HasColumnType("integer");

                    b.Property<int?>("ThumbsUp")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("ProductComments");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductCommentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductImageId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductPropertyId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ShippingSettingId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("ProductCommentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductImageId");

                    b.HasIndex("ProductPropertyId");

                    b.HasIndex("ShippingSettingId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("VarKey")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("VarValue")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("ProductProperties");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ShippingSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsShippingFree")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("ShippingSettings");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastIPAddress")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("character varying(12)")
                        .HasMaxLength(12);

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                            AvatarUrl = "/",
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastIPAddress = "127.0.0.1",
                            LastLogin = new DateTime(2021, 10, 4, 19, 59, 48, 895, DateTimeKind.Local).AddTicks(9116),
                            LastName = "Admin",
                            Password = "123",
                            Status = 1,
                            Title = "admin"
                        });
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.UserDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(11);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uuid");

                    b.Property<int?>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("TCKN")
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedIp")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.Brand", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserBrand")
                        .WithMany("CreatedUserBrands")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserBrand")
                        .WithMany("UpdatedUserBrands")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.Category", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserCategory")
                        .WithMany("CreatedUserCategories")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserCategory")
                        .WithMany("UpdatedUserCategories")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.CommentReaction", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserCommentReaction")
                        .WithMany("CreatedUserCommentReactions")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.ProductComment", "Comment")
                        .WithMany("CommentReactions")
                        .HasForeignKey("ProductCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserCommentReaction")
                        .WithMany("UpdatedUserCommentReactions")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.Product", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserProduct")
                        .WithMany("CreatedUserProducts")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserProduct")
                        .WithMany("UpdatedUserProducts")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductComment", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserProductComment")
                        .WithMany("CreatedUserProductComments")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.Product", "Product")
                        .WithMany("ProductComments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserProductComment")
                        .WithMany("UpdatedUserProductComments")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductDetail", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserProductDetail")
                        .WithMany("CreatedUserProductDetails")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.ProductComment", "ProductComment")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.ProductImage", "ProductImage")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.ProductProperty", "ProductProperty")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.ShippingSetting", "ShippingSetting")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ShippingSettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserProductDetail")
                        .WithMany("UpdatedUserProductDetails")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductImage", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserProductImage")
                        .WithMany("CreatedUserProductImages")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserProductImage")
                        .WithMany("UpdatedUserProductImages")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ProductProperty", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserProductProperty")
                        .WithMany("CreatedUserProductProperties")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.Product", "Product")
                        .WithMany("ProductProperties")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserProductProperty")
                        .WithMany("UpdatedUserProductProperties")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.ShippingSetting", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserShippingSetting")
                        .WithMany("CreatedUserShippingSettings")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.Product", "Product")
                        .WithMany("ShippingSettings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserShippingSetting")
                        .WithMany("UpdatedUserShippingSettings")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.User", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUser")
                        .WithMany("CreatedUsers")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUser")
                        .WithMany("UpdatedUsers")
                        .HasForeignKey("UpdatedUserId");
                });

            modelBuilder.Entity("CommercialSite.Model.Entities.UserDetail", b =>
                {
                    b.HasOne("CommercialSite.Model.Entities.User", "CreatedUserDetail")
                        .WithMany("CreatedUserDetails")
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.User", "UpdatedUserDetail")
                        .WithMany("UpdatedUserDetails")
                        .HasForeignKey("UpdatedUserId");

                    b.HasOne("CommercialSite.Model.Entities.User", "User")
                        .WithMany("UserDetails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
