﻿// <auto-generated />
using System;
using ComputerShopll.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComputerShopll.Migrations
{
    [DbContext(typeof(ComputershopDbContext))]
    [Migration("20250627073936_AddIdentity")]
    partial class AddIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ComputerShopll.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ComputerShopll.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ComputerShopll.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrendingProduct")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Detail = "Đây là dòng máy rất phù hợp với ae văn phòng, với thiết kế mọng và nhẹ rất phù hợp đẻ cầm.",
                            ImageUrl = "https://s.yimg.com/os/creatr-uploaded-images/2023-01/fb0dce50-8a31-11ed-b3ff-b8d61a9c0194",
                            IsTrendingProduct = false,
                            Name = "Laptop Asus Zenbook 14",
                            Price = 21990000m
                        },
                        new
                        {
                            Id = 2,
                            Detail = "Đây là dòng máy gaming đến từ nhà Asus với thiết kế hầm hồ và hiệu năng cao từ đó mang lại trải nghiệm tốt nhất khi học tập và làm việc",
                            ImageUrl = "https://s.yimg.com/os/creatr-uploaded-images/2023-01/fb0dce50-8a31-11ed-b3ff-b8d61a9c0194",
                            IsTrendingProduct = false,
                            Name = "Asus Gaming F15",
                            Price = 20990000m
                        },
                        new
                        {
                            Id = 3,
                            Detail = "Được tạo ra dựa trên chip M4, M4 Pro cho bạn hiệu năng mạnh mẽ hơn nữa và bộ nhớ thống nhất tăng cường để làm việc với những ứng dụng và luồng công việc đỏi hỏi cao, và Neural Engine giúp bạn xử lý nhanh chóng các quy trình làm việc chuyên nghiệp trên AI",
                            ImageUrl = "https://s.yimg.com/os/creatr-uploaded-images/2023-01/fb0dce50-8a31-11ed-b3ff-b8d61a9c0194",
                            IsTrendingProduct = false,
                            Name = "Macbook 16 Pro",
                            Price = 32990000m
                        },
                        new
                        {
                            Id = 4,
                            Detail = "Dễ dàng sắp xếp trong không gian làm việc, tiết kiệm diện tích và đáp ứng tốt nhu cầu sử dụng văn phòng như soạn thảo văn bản, lướt web, và sử dụng phần mềm chuyên dụng",
                            ImageUrl = "https://thuthuatnhanh.com/wp-content/uploads/2021/06/Hinh-anh-may-tinh-xin-nhat-585x390.jpg",
                            IsTrendingProduct = false,
                            Name = "Pc văn phòng",
                            Price = 15000000m
                        },
                        new
                        {
                            Id = 5,
                            Detail = "Đúng như tên gọi của nó thì đây là dòng máy chuyên dùng để chơi các thể loại game với cấu hình và hiệu năng cáo giúp trải nhiệm về game hiệu quả",
                            ImageUrl = "https://thuthuatnhanh.com/wp-content/uploads/2021/06/Hinh-anh-may-tinh-xin-nhat-585x390.jpg",
                            IsTrendingProduct = false,
                            Name = "Pc chuyên game",
                            Price = 22200000m
                        },
                        new
                        {
                            Id = 6,
                            Detail = "Đây là sự kết hợp giữa Pc văn phòng và PC chơi game không chỉ nhỏ gọn, tiết kiệm diện tích và đáp ứng tốt nhu cầu sử dụng văn phòng như soạn thảo văn bản, lướt web, và sử dụng phần mềm chuyên dụng mà còn đem lại hiệu năng cáo giúp trải nhiệm về game hiệu quả ",
                            ImageUrl = "/images/",
                            IsTrendingProduct = false,
                            Name = "Pc hiệu năng cao",
                            Price = 30000000m
                        },
                        new
                        {
                            Id = 7,
                            Detail = "Đây là dòng phím Gaming mới nhất đến từ nhà logitech với thiết kế gọn gàng, tích kiểm diẹn tích ",
                            ImageUrl = "https://hanoicomputercdn.com/media/lib/49500_ban-phim-co-Logitech-G-Pro-X-RGB-Lightsync-Mechanical-GX-Blue-Switch-3.jpg",
                            IsTrendingProduct = false,
                            Name = "Phím cơ Logitech Pro",
                            Price = 2500000m
                        },
                        new
                        {
                            Id = 8,
                            Detail = "Đây là dòng phím Gaming mới nhất đến từ nhà logitech với thiết kế gọn gàng, tích kiểm diẹn tích ",
                            ImageUrl = "https://hanoicomputercdn.com/media/lib/49500_ban-phim-co-Logitech-G-Pro-X-RGB-Lightsync-Mechanical-GX-Blue-Switch-3.jpg",
                            IsTrendingProduct = false,
                            Name = "Phím cơ Logitech",
                            Price = 1800000m
                        },
                        new
                        {
                            Id = 9,
                            Detail = "Đây là dòng phím Gaming mới nhất đến từ nhà logitech với thiết kế gọn gàng, tích kiểm diẹn tích ",
                            ImageUrl = "https://hanoicomputercdn.com/media/lib/49500_ban-phim-co-Logitech-G-Pro-X-RGB-Lightsync-Mechanical-GX-Blue-Switch-3.jpg",
                            IsTrendingProduct = false,
                            Name = "Phím bản giới hạn",
                            Price = 3500000m
                        },
                        new
                        {
                            Id = 10,
                            Detail = "Đây là thanh RAM thế hệ thứ 4 của nhà Kingston có hiệu năng cao",
                            ImageUrl = "https://th.bing.com/th/id/R.e2e9fe4a4d48d42c3831293df3303b6b?rik=HHHl706DT2o%2f4Q&riu=http%3a%2f%2fs3.amazonaws.com%2fdigitaltrends-uploads-prod%2f2017%2f05%2fHyperX-Predator-DDR4.jpg&ehk=p0pVo6Lm2g2MO%2fh8AzisdtHf3szuzXiUoOiKZBboXe8%3d&risl=&pid=ImgRaw&r=0",
                            IsTrendingProduct = false,
                            Name = "Ram Kingston DDR4",
                            Price = 1500000m
                        },
                        new
                        {
                            Id = 11,
                            Detail = "Đây là thanh RAM thế hệ thứ 5 của nhà Kingston có hiệu năng cao",
                            ImageUrl = "https://th.bing.com/th/id/R.e2e9fe4a4d48d42c3831293df3303b6b?rik=HHHl706DT2o%2f4Q&riu=http%3a%2f%2fs3.amazonaws.com%2fdigitaltrends-uploads-prod%2f2017%2f05%2fHyperX-Predator-DDR4.jpg&ehk=p0pVo6Lm2g2MO%2fh8AzisdtHf3szuzXiUoOiKZBboXe8%3d&risl=&pid=ImgRaw&r=0",
                            IsTrendingProduct = false,
                            Name = "Ram Kingston DDR5",
                            Price = 3000000m
                        });
                });

            modelBuilder.Entity("ComputerShopll.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("shoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ComputerShopll.Models.OrderDetail", b =>
                {
                    b.HasOne("ComputerShopll.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerShopll.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ComputerShopll.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ComputerShopll.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComputerShopll.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
