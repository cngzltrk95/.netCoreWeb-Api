﻿// <auto-generated />
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataBase.Migrations
{
    [DbContext(typeof(appContext))]
    partial class appContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DataBase.Models.accountType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("accountName");

                    b.HasKey("ID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DataBase.Models.creditType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("creditName");

                    b.HasKey("ID");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("DataBase.Models.interest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accountId");

                    b.Property<int>("creditId");

                    b.Property<double>("value");

                    b.HasKey("ID");

                    b.HasIndex("accountId");

                    b.HasIndex("creditId");

                    b.ToTable("interests");
                });

            modelBuilder.Entity("DataBase.Models.user", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accountId");

                    b.Property<string>("email");

                    b.Property<string>("pass");

                    b.Property<string>("userLastName");

                    b.Property<string>("userName");

                    b.HasKey("ID");

                    b.HasIndex("accountId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataBase.Models.interest", b =>
                {
                    b.HasOne("DataBase.Models.accountType", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataBase.Models.creditType", "credit")
                        .WithMany()
                        .HasForeignKey("creditId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataBase.Models.user", b =>
                {
                    b.HasOne("DataBase.Models.accountType", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
