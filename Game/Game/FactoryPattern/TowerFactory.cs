using System.Drawing;
using Game.Entities.Buildings;
using Game.Helpers.Enums;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.FactoryPattern
{
    public class TowerFactory
    {
        public Building CreateNew(TowerTypes towerType, Point location)
        {
            if (towerType == TowerTypes.Arrow)
            {
                var Tower = new Tower(location);
                Tower.SetSpwaner(new ArrowSpawn());
                
                return new ArrowTower(new Tower(location));
            }

            if (towerType == TowerTypes.Cannon)
            {
                var Tower = new Tower(location);
                Tower.SetSpwaner(new BombSpawn());
                
                return new CannonTower(new Tower(location));
            }

            return null;
        }
    }
}