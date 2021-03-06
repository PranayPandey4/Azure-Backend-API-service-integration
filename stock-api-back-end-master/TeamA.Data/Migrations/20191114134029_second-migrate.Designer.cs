// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamA.Data;

namespace TeamA.Data.Migrations
{
    [DbContext(typeof(ProductManagementDb))]
    [Migration("20191114134029_second-migrate")]
    partial class secondmigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamA.Models.StockDto", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ProductID");

                    b.Property<double>("ResellPrice");

                    b.Property<int>("StockLevel");

                    b.HasKey("ID");

                    b.ToTable("Stock");
                });
#pragma warning restore 612, 618
        }
    }
}
