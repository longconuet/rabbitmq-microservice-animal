using RabbitMQAnimal.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace RabbitMQAnimal.API.DTOs
{
    public class CreateAnimalDto
    {
        [Required]
        public int Age { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string CoverImageUrl { get; set; }
        [Required]
        public Status Status { get; set; }
    }
}
