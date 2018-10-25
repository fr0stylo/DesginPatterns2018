using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAPI.Data
{
    public class TowersDefenseRepository : ITowersDefenseRepository
    {
        private readonly DataContext _context;

        public TowersDefenseRepository(DataContext context)
        {
            this._context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Baloon> GetBaloon(int baloonId)
        {
            var baloon = await _context.Baloons.FirstOrDefaultAsync(x => x.BaloonId == baloonId);

            return baloon;
        }

        public async Task<Game> GetGame(int GameId)
        {
            var game = await _context.Games.FirstOrDefaultAsync(x => x.GameId == GameId);

            return game;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
