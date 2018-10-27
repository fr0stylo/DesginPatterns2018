using System.Collections.Generic;

namespace Game.Entities
{
    public class Player
    {
        public string Name { get; }
        public int MoneyPoints { get; private set; }
        public int HealthPoints { get; private set; }
        private List<Tower> Towers;

        public Player(string name)
        {
            Name = name;
            MoneyPoints = 1000;
            HealthPoints = 100;
            Towers = new List<Tower>();
        }

        public void DecreaseHealthPoints(int pointsToDecrease)
        {
            HealthPoints += pointsToDecrease;
        }

        public void AdjustMoneyPoints(int moneyAmount)
        {
            MoneyPoints += moneyAmount;
        }

        public void AddTower(Tower tower)
        {
            Towers.Add(tower);
        }

        public List<Tower> GetTowers()
        {
            return Towers;
        }
    }
}