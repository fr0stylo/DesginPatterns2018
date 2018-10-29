using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameAPI.Models;

namespace GameAPI.Observers
{
    public class GameSubject
    {
        public ICollection<Tower> Towers { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Baloon> Baloons { get; set; }

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

        public void AttachPlayr(Player player)
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

        public void NotifyBaloonHealth(int baloonId, int health)
        {
            //Dont know how from ICollection get a single baloon :DDD
        }
    }
}
