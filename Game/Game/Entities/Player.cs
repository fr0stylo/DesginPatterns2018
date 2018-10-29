using System.Collections.Generic;
using Game.Entities.Buildings;

namespace Game.Entities
{
    public class Player
    {
        public string Name { get; }
        public int MoneyPoints { get; private set; }
        public int HealthPoints { get; private set; }
        private List<Building> Buildings;

        public Player(string name)
        {
            Name = name;
            MoneyPoints = 1000;
            HealthPoints = 100;
            Buildings = new List<Building>();
        }

        public void DecreaseHealthPoints(int pointsToDecrease)
        {
            HealthPoints += pointsToDecrease;
        }

        public void AdjustMoneyPoints(int moneyAmount)
        {
            MoneyPoints += moneyAmount;
        }

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }

        public List<Building> GetBuildings()
        {
            return Buildings;
        }
    }
}