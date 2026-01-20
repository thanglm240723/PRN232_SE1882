using AutoMapper;
using WebAPI_Models_DTOs.DBContext.Models;
using WebAPI_Models_DTOs.Dto.Player;
using WebAPI_Models_DTOs.Dto.PlayerInstrument;

namespace WebAPI_Models_DTOs.Mapper

{
    public class MapperConfig : Profile
    {

        public MapperConfig()
        {

            CreateMap<Player , GetPlayerDetailResponse >().ReverseMap();
            CreateMap<CreatePlayerRequest, Player>().ReverseMap();

            CreateMap<PlayerInstrument, GetPlayerDetailResponse>().ReverseMap();
            CreateMap<CreatePlayerInstrumentRequest, PlayerInstrument>().ReverseMap();
        }
    }
}
