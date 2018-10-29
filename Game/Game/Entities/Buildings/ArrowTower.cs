using System.Drawing;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities.Buildings
{
    public class ArrowTower : TowerDecorator
    {
        public ArrowTower(Building newBuilding) : base(newBuilding) {}
        
        public override int GetPrice()
        {
            return base.GetPrice() + 100;
        }
    }
}