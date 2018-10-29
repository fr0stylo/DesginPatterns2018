using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPI.Interfaces;

namespace GameAPI.Models
{
    public class Player : IPlayerObserver
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int MoneyPoints { get; set; }

        public int HealthPoints { get; set; }   

        public int GameId { get; set; }
        public Game Game { get; set; }

        public void UpdateMoney(int score)
        {
            this.MoneyPoints += score;
        }

        public void UpdateHealth(int health)
        {
            this.HealthPoints += health;
        }
    }
}
