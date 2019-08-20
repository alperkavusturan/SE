using AutoMapper;
using ProfileService.Api.DTOs;


namespace ProfileService.Api.Helper.Mapper.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Data.Models.Profile, ProfileDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.ProfileTypeId, opt => opt.MapFrom(src => src.ProfileType.Id))
                .ForMember(dest => dest.ProfileTypeName, opt => opt.MapFrom(src => src.ProfileType.Name));

            CreateMap<CreateProfileDTO, Data.Models.Profile>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.ProfileTypeId, opt => opt.MapFrom(src => src.ProfileTypeId));

            CreateMap<UpdateProfileDTO, Data.Models.Profile>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.ProfileTypeId, opt => opt.MapFrom(src => src.ProfileTypeId));

            CreateMap<DeleteProfileDTO, Data.Models.Profile>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

        }
    }
}
