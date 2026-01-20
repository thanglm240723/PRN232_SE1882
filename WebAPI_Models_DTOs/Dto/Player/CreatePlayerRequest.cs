namespace WebAPI_Models_DTOs.Dto.Player
{
    public class CreatePlayerRequest
    {
        public string NickName { get; set; }
        public List<CreatePlayerRequest> PlayerInstruments{ get; set; }


    }
}
