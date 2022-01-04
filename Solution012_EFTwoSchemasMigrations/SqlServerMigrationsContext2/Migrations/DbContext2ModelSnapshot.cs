﻿// <auto-generated />
using System;
using Context2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SqlServerMigrationsContext2.Migrations
{
    [DbContext(typeof(DbContext2))]
    partial class DbContext2ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Context2.Context1Entity1", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entity1s", "Context1", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Context2.Context2Entity1", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entity1s", "Context2");
                });

            modelBuilder.Entity("Context2.Context2Entity2", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Context1Entity1Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Entity1Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Context1Entity1Id");

                    b.HasIndex("Entity1Id");

                    b.ToTable("Entity2s", "Context2");
                });

            modelBuilder.Entity("Context2.Context2Entity2", b =>
                {
                    b.HasOne("Context2.Context1Entity1", "Context1Entity1")
                        .WithMany()
                        .HasForeignKey("Context1Entity1Id");

                    b.HasOne("Context2.Context2Entity1", "Entity1")
                        .WithMany()
                        .HasForeignKey("Entity1Id");

                    b.Navigation("Context1Entity1");

                    b.Navigation("Entity1");
                });
#pragma warning restore 612, 618
        }
    }
}
