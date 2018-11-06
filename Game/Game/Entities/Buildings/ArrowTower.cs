using System.Drawing;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities.Buildings
{
    public class ArrowTower : TowerDecorator
    {
        private DebugLogSingleton _singleton = DebugLogSingleton.GetInstance();

        public ArrowTower(Building newBuilding) : base(newBuilding) {
            _singleton.Log<ArrowTower>("Decorator", "Creatin arrow tower.");
        }
        
        public override int GetPrice()
        {
            return base.GetPrice() + 100;
        }
    }
}