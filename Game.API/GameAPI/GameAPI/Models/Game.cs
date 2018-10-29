using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPI.Observers;

namespace GameAPI.Models
{
    public class Game : GameSubject
    {
        public int GameId { get; set; }

        //When baloon is killed
        public void ChangeMoneyScore(int moneyScore)
        {
            NotifyMoneyScore(moneyScore);
        }

        public void AddMoneyTo(int playerId, int money)
        {
            AddMoneyToPlayer(playerId, money);
        }

        //When tower hit baloon
        public void ChangeBaloonHealth(int baloonId, int health)
        {
            NotifyBaloonHealth(baloonId, health);
        }

        public void SetGameId(int gameId)
        {
            this.GameId = gameId;
        }
    }
}
