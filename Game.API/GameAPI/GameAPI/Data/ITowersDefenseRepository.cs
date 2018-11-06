using GameAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Data
{
    public interface ITowersDefenseRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<Baloon> GetBaloon(int baloonId);

        Task<Player> GetPlayer(int playerId);

        Task<Game> GetGame(int GameId);
    }
}
