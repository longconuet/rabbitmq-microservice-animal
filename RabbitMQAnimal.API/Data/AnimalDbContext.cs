﻿using MassTransit;
using Microsoft.EntityFrameworkCore;
using RabbitMQAnimal.API.Entities;

namespace RabbitMQAnimal.API.Data
{
    public class AnimalDbContext : DbContext
    {
        public AnimalDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Add in memory outbox
            builder.AddInboxStateEntity();
            builder.AddOutboxMessageEntity();
            builder.AddOutboxStateEntity();

            // Seed data
            builder.Entity<Animal>().HasData(new Animal
            {
                Id = Guid.NewGuid(),
                PublicId = 1,
                Name = "Dee Dee",
                Type = "Dog",
                Description = "lorem ipsum",
                Breed = "Double doodle",
                Sex = "Female",
                Color = "White",
                Weight = 10,
                Age = 2,
                Status = Status.Available,
                CoverImageUrl = "https://placedog.net/500",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            });
            builder.Entity<Animal>().HasData(new Animal
            {
                Id = Guid.NewGuid(),
                PublicId = 2,
                Name = "Buttercup",
                Type = "Cat",
                Description = "lorem ipsum",
                Breed = "Bengal cat",
                Sex = "Male",
                Color = "Beige",
                Weight = 5,
                Age = 5,
                Status = Status.Available,
                CoverImageUrl = "https://placekitten.com/200/200",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            });
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
