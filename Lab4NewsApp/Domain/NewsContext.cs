using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4NewsApp.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab4NewsApp.Domain
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {
        }

        public DbSet<NewsItem> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            
        }
    }
}

public class NewsConfiguration : IEntityTypeConfiguration<NewsItem>
{
    public void Configure(EntityTypeBuilder<NewsItem> builder)
    {
        builder.HasData(
            new NewsItem
            {
                Id = 1,
                Heading = "UFO spotted",
                Body = "Last night a UFO was spotted flying over the city.",
                PublishTime = DateTime.UtcNow.AddDays(-6)
            },
            new NewsItem
            {
                Id = 2,
                Heading = "Lecturer sentenced to prison",
                Body = "A lecturer was sentenced to prison as their lectures were so boring students died.",
                PublishTime = DateTime.UtcNow.AddDays(-5)
            },
            new NewsItem
            {
                Id = 3,
                Heading = "Finland: new temperature record",
                Body =
                    "Yesterday officials recorded a record +22 degrees Celcius in Helsinki, Finland. It is the hottest summer Finland has seen in decades.",
                PublishTime = DateTime.UtcNow.AddDays(-4)
            },
            new NewsItem
            {
                Id = 4,
                Heading = "Nothing interesting happened today",
                Body = "Literally, absolutely nothing worth writing news about occurred today.",
                PublishTime = DateTime.UtcNow.AddDays(-3)
            },
            new NewsItem
            {
                Id = 5,
                Heading = "The four seasons for Finnish national railways",
                Body =
                    "For completely unknown reasons, it seems the Finnish national railways have problems every season. In the winter it is the snow and ice. In the autumn it is the falling leaves. In the spring and summer it is for no apparent reason.",
                PublishTime = DateTime.UtcNow.AddDays(-2)
            },
            new NewsItem
            {
                Id = 6,
                Heading = "Test news",
                Body = "This is just a test. Please ignore.",
                PublishTime = DateTime.UtcNow.AddDays(-1)
            });
    }
}
