using AutoMapper;
using Events;
using RabbitMQAnimal.API.DTOs;
using RabbitMQAnimal.API.Entities;

namespace RabbitMQAnimal.API.Helpers
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper() 
        {
            CreateMap<Animal, AnimalDto>();
            CreateMap<CreateAnimalDto, Animal>();
            CreateMap<AnimalDto, AnimalCreated>();
            CreateMap<Animal, AnimalUpdated>();
        }
    }
}
