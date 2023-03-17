using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

public class MappingConfigurations : Profile
{
    public MappingConfigurations()
    {
        CreateMap<Show, ShowCreate>().ReverseMap();
        CreateMap<Show, ShowDetail>().ReverseMap();
        CreateMap<Show, ShowListItem>().ReverseMap();

        CreateMap<Season, SeasonListItem>().ReverseMap();
        CreateMap<Season, SeasonDetail>().ReverseMap();

        CreateMap<Character, CharacterDetail>().ReverseMap();
        CreateMap<Character, CharacterListItem>().ReverseMap();
        CreateMap<Character, CharacterCreate>().ReverseMap();

    }
}
