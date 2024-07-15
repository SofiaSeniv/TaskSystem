using AutoMapper;
using TaskSystem.Domain.DTO;
using TaskSystem.Domain.Entity;

namespace TaskSystem.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskUpdateDto, TaskEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());
        }
    }
}
