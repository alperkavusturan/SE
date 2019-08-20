using AutoMapper;
using VenueService.Api.DTOs;
using VenueService.Data.Models;

namespace VenueService.Api.Helper.Mapper.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Venue, VenueDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.District, opt => opt.MapFrom(src => src.District))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.VenueTypeId, opt => opt.MapFrom(src => src.VenueType.Id))
                .ForMember(dest => dest.VenueTypeName, opt => opt.MapFrom(src => src.VenueType.Name));

            CreateMap<CreateVenueDTO, Venue>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.District, opt => opt.MapFrom(src => src.District))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.VenueTypeId, opt => opt.MapFrom(src => src.VenueTypeId));

            CreateMap<UpdateVenueDTO, Venue>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.District, opt => opt.MapFrom(src => src.District))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.VenueTypeId, opt => opt.MapFrom(src => src.VenueTypeId));

            CreateMap<DeleteVenueDTO, Venue>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

        }
    }
}
