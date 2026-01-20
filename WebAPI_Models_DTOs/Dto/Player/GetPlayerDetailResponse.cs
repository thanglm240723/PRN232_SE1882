namespace WebAPI_Models_DTOs.Dto.Player
{
    public class GetPlayerDetailResponse
    {
        public string NickName { get; set; }    
        public string JoinedDate { get; set; }
         
        public List<GetPlayerDetailResponse> PlayerInstruments { get; set; }
    }
}
