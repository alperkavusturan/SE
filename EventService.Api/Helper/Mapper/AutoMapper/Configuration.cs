using AutoMapper;
using EventService.Api.DTOs;
using EventService.Data.Models;

namespace EventService.Api.Helper.Mapper.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {
            CreateMap<Event, EventDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ArtistsIds, opt => opt.MapFrom(src => src.ArtistsId));

            CreateMap<CreateEventDTO, Event>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.EventTypeId, opt => opt.MapFrom(src => src.EventTypeId))
                .ForMember(dest => dest.ArtistsId, opt => opt.MapFrom(src => src.ArtistsId))
                .ForMember(dest => dest.VenueId, opt => opt.MapFrom(src => src.VenueId))
                .ForMember(dest => dest.PromotersId, opt => opt.MapFrom(src => src.PromotersId));


        }
    }
}
