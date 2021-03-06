// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SamverkandeAPI.Data;

namespace SamverkandeAPI.Migrations
{
    [DbContext(typeof(PrenumeranterDbContext))]
    partial class PrenumeranterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SamverkandeAPI.Models.Prenumeranter", b =>
                {
                    b.Property<int>("Pr_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pr_Efternamn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pr_Epost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pr_Fornamn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pr_Mobil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pr_Ort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pr_Personnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pr_Postnummer")
                        .HasColumnType("int");

                    b.Property<string>("Pr_Utdelningsadress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pr_Id");

                    b.ToTable("Prenumeranter");
                });
#pragma warning restore 612, 618
        }
    }
}
