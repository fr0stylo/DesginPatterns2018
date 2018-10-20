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
            var baloon = await _context.Baloons.FirstOrDefaultAsync(x => x.Id == baloonId);

            return baloon;
        }

        public async Task<IEnumerable<Baloon>> GetBaloons(int playerId)
        {
            var baloons = await _context.Baloons.Where(x => x.PlayerId == playerId).ToListAsync();
            return baloons;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
