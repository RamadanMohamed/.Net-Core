// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab6mvccore.Models;

namespace lab6mvccore.Migrations
{
    [DbContext(typeof(ITIModel))]
    [Migration("20211217052900_db1")]
    partial class db1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("lab6mvccore.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("deptid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.HasIndex("deptid");

                    b.ToTable("students");
                });

            modelBuilder.Entity("lab6mvccore.Models.department", b =>
                {
                    b.Property<int>("deptid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("deptname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("deptid");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("lab6mvccore.Models.Student", b =>
                {
                    b.HasOne("lab6mvccore.Models.department", "department")
                        .WithMany("students")
                        .HasForeignKey("deptid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("lab6mvccore.Models.department", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
