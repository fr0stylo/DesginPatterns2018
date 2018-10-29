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

        //When tower hit baloon
        public void ChangeBaloonHealth(int baloonId, int health) { }
    }
}
