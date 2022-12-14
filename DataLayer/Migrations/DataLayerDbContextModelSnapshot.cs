// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(DataLayerDbContext))]
    partial class DataLayerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Model.Sessions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Draw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Jackpot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("DataLayer.Model.Tickets", b =>
                {
                    b.Property<string>("shortGUID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Combination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SessionsId")
                        .HasColumnType("int");

                    b.HasKey("shortGUID");

                    b.HasIndex("SessionsId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DataLayer.Model.Tickets", b =>
                {
                    b.HasOne("DataLayer.Model.Sessions", "Sessions")
                        .WithMany("Tickets")
                        .HasForeignKey("SessionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("DataLayer.Model.Sessions", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
