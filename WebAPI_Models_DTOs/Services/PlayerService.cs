using AutoMapper;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Security.Cryptography;
using WebAPI_Models_DTOs.DBContext.Models;
using WebAPI_Models_DTOs.Dto;
using WebAPI_Models_DTOs.Dto.Player;

namespace WebAPI_Models_DTOs.Services
{
    public class PlayerService : IPlayerService
    {

        private readonly List<GetPlayerDetailResponse> _players;
        private readonly IMapper _mapper;
        public PlayerService(IMapper mapper)
        {
            _mapper = mapper;
            _players = new List<GetPlayerDetailResponse>();
        }

        public async Task CreatePlayerAsync(CreatePlayerRequest createPlayerRequest)
        {
            var player = _mapper.Map<GetPlayerDetailResponse>(createPlayerRequest);
            player.JoinedDate = DateTime.UtcNow;
            var PlayerInstrument = _mapper.Map<List<PlayerInstrument>>(createPlayerRequest.PlayerInstruments);

          await _context.Players.AddAsync(player);
            return Task.CompletedTask;
        }

        public Task<bool> DeletePlayerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetPlayerDetailResponse?> GetPlayerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Dto.PagedResponse<GetPlayerDetailResponse>> GetPlayersAsync(UrlQueryParameter urlQueryParameter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest updatePlayerRequest)
        {
            throw new NotImplementedException();
        }
    }
}

