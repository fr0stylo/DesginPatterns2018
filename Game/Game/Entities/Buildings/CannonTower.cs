using System.Drawing;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities.Buildings
{
    public class CannonTower : TowerDecorator
    {
        private DebugLogSingleton _singleton = DebugLogSingleton.GetInstance();

        public CannonTower(Building newBuilding) : base(newBuilding) {
            _singleton.Log<ArrowTower>("Decorator", "Creatin cannon tower.");
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 250;
        }
    }
}