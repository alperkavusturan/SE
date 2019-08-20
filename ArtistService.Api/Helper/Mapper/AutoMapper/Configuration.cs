using ArtistService.Api.DTOs;
using ArtistService.Data.Models;
using AutoMapper;

namespace ArtistService.Api.Helper.Mapper.AutoMapper
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {
            CreateMap<Artist, ArtistDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.Nickname, opt => opt.MapFrom(src => src.Nickname))
                .ForMember(dest => dest.ArtistTypeId, opt => opt.MapFrom(src => src.ArtistType.Id))
                .ForMember(dest => dest.ArtistTypeName, opt => opt.MapFrom(src => src.ArtistType.Name));

            CreateMap<CreateArtistDTO, Artist>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.Nickname, opt => opt.MapFrom(src => src.Nickname))
                .ForMember(dest => dest.ArtistTypeId, opt => opt.MapFrom(src => src.ArtistTypeId));

            CreateMap<UpdateArtistDTO, Artist>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.Nickname, opt => opt.MapFrom(src => src.Nickname))
                .ForMember(dest => dest.ArtistTypeId, opt => opt.MapFrom(src => src.ArtistTypeId));

            CreateMap<DeleteArtistDTO, Artist>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
        }
    }
}
