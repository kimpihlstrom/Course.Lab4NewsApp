﻿// <auto-generated />
using System;
using Lab4NewsApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab4NewsApp.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20181004125709_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab4NewsApp.Domain.NewsItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("Heading");

                    b.Property<DateTime>("PublishTime");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new { Id = 1L, Body = "Last night a UFO was spotted flying over the city.", Heading = "UFO spotted", PublishTime = new DateTime(2018, 9, 28, 12, 57, 8, 688, DateTimeKind.Utc) },
                        new { Id = 2L, Body = "A lecturer was sentenced to prison as their lectures were so boring students died.", Heading = "Lecturer sentenced to prison", PublishTime = new DateTime(2018, 9, 29, 12, 57, 8, 688, DateTimeKind.Utc) },
                        new { Id = 3L, Body = "Yesterday officials recorded a record +22 degrees Celcius in Helsinki, Finland. It is the hottest summer Finland has seen in decades.", Heading = "Finland: new temperature record", PublishTime = new DateTime(2018, 9, 30, 12, 57, 8, 688, DateTimeKind.Utc) },
                        new { Id = 4L, Body = "Literally, absolutely nothing worth writing news about occurred today.", Heading = "Nothing interesting happened today", PublishTime = new DateTime(2018, 10, 1, 12, 57, 8, 688, DateTimeKind.Utc) },
                        new { Id = 5L, Body = "For completely unknown reasons, it seems the Finnish national railways have problems every season. In the winter it is the snow and ice. In the autumn it is the falling leaves. In the spring and summer it is for no apparent reason.", Heading = "The four seasons for Finnish national railways", PublishTime = new DateTime(2018, 10, 2, 12, 57, 8, 688, DateTimeKind.Utc) },
                        new { Id = 6L, Body = "This is just a test. Please ignore.", Heading = "Test news", PublishTime = new DateTime(2018, 10, 3, 12, 57, 8, 688, DateTimeKind.Utc) }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
