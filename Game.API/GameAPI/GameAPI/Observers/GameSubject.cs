using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPI.Models;

namespace GameAPI.Observers
{
    public class GameSubject
    {
        public List<Tower> Towers = new List<Tower>();
        public List<Player> Players = new List<Player>();
        public List<Baloon> Baloons = new List<Baloon>();

        public void AttachTower(Tower tower)
        {
            //For way 1 lets assign attach the observers with subjects
            Towers.Add(tower);
        }
        public void DetachTower(Tower tower)
        {
            //For way 1 lets assign detach the observers with subjects
            Towers.Remove(tower);
        }

        public void AttachPlayer(Player player)
        {
            //For way 2 lets assign attach the observers with subjects
            Players.Add(player);
        }

        public void DetachPlayer(Player player)
        {
            //For way 1 lets assign detach the observers with subjects
            Players.Remove(player);
        }

        public void AttachBaloons(Baloon baloon)
        {
            //For way 2 lets assign attach the observers with subjects
            Baloons.Add(baloon);
        }

        public void DetachBaloons(Baloon baloon)
        {
            //For way 1 lets assign detach the observers with subjects
            Baloons.Remove(baloon);
        }

        public void NotifyMoneyScore(int score)
        {
            foreach (Player p in Players)
            {
                p.UpdateMoney(score);
            }
        }

        public void AddMoneyToPlayer(int playerId, int money)
        {
            var player = Players.FirstOrDefault(e => e.PlayerId == playerId);

            player.UpdateMoney(money);
        }

        public void NotifyBaloonHealth(int baloonId, int health)
        {
            var baloon = Baloons.FirstOrDefault(e => e.BaloonId == baloonId);

            baloon.UpdateHealth(health);

            if (!baloon.IsAlive)
            {
                NotifyMoneyScore(15);
            }
        }
    }
}
