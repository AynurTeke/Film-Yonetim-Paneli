// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using filmUygulamasi.Models;

namespace filmUygulamasi.Migrations
{
    [DbContext(typeof(uygulamaContext))]
    [Migration("20221118083257_arrangement")]
    partial class arrangement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnionArcExample.Domain.Entities.film", b =>
                {
                    b.Property<int>("filmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("filmAd")
                        .IsRequired()
                        .HasColumnType("nchar(250)");

                    b.Property<int>("filmYapimYil")
                        .HasColumnType("int");

                    b.HasKey("filmID");

                    b.ToTable("films");
                });

            modelBuilder.Entity("OnionArcExample.Domain.Entities.filmSalon", b =>
                {
                    b.Property<int>("filmSalonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("filmID")
                        .HasColumnType("int");

                    b.Property<int>("salonID")
                        .HasColumnType("int");

                    b.HasKey("filmSalonID");

                    b.HasIndex("filmID");

                    b.HasIndex("salonID");

                    b.ToTable("filmSalons");
                });

            modelBuilder.Entity("OnionArcExample.Domain.Entities.salon", b =>
                {
                    b.Property<int>("salonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("salonAd")
                        .IsRequired()
                        .HasColumnType("nchar(250)");

                    b.HasKey("salonID");

                    b.ToTable("salons");
                });

            modelBuilder.Entity("OnionArcExample.Domain.Entities.filmSalon", b =>
                {
                    b.HasOne("OnionArcExample.Domain.Entities.film", "film")
                        .WithMany()
                        .HasForeignKey("filmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnionArcExample.Domain.Entities.salon", "salon")
                        .WithMany()
                        .HasForeignKey("salonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("film");

                    b.Navigation("salon");
                });
#pragma warning restore 612, 618
        }
    }
}
