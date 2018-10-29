using System.Drawing;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities.Buildings
{
    public class CannonTower : TowerDecorator
    {
        public CannonTower(Building newBuilding) : base(newBuilding) {}

        public override int GetPrice()
        {
            return base.GetPrice() + 250;
        }
    }
}