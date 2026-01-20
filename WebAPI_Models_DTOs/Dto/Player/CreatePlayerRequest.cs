using WebAPI_Models_DTOs.Dto.PlayerInstrument;

namespace WebAPI_Models_DTOs.Dto.Player
{
    public class CreatePlayerRequest
    {
        public string NickName { get; set; }
        public List<CreatePlayerInstrumentRequest> PlayerInstruments{ get; set; }


    }
}
