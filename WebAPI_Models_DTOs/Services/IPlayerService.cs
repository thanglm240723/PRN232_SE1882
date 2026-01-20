using WebAPI_Models_DTOs.Dto;
using WebAPI_Models_DTOs.Dto.Player;

namespace WebAPI_Models_DTOs.Services
{
    public interface IPlayerService
    {
        Task CreatePlayerAsync( CreatePlayerRequest createPlayerRequest);
        Task<bool> UpdatePlayerAsync(int id , UpdatePlayerRequest updatePlayerRequest);

        Task<bool> DeletePlayerAsync(int id);
        Task<GetPlayerDetailResponse?> GetPlayerByIdAsync(int id);
        Task<PagedResponse<GetPlayerDetailResponse>> GetPlayersAsync(UrlQueryParameter urlQueryParameter);


    }
}
