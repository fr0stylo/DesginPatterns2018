using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPI.Interfaces;

namespace GameAPI.Models
{
    public class Baloon : IBaloonObserver
    {
        public int BaloonId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }
        public bool AttackPlayer1 { get; set; }
        public bool AttackPlayer2 { get; set; }

        public Baloon(int BaloonId, int GameId)
        {
            this.BaloonId = BaloonId;
            this.GameId = GameId;
            this.Type = "Simple";
            this.Health = 20;
            this.IsAlive = true;
        }

        public void UpdateHealth(int health)
        {
            if (this.Health - health <= 0)
            {
                this.IsAlive = false;
                this.Health = 0;
            }
            else
            {
                this.Health -= health;
            }
        }
    }
}
