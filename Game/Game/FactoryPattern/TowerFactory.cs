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
                var tower = new Tower(location);
                tower.SetSpwaner(new ArrowSpawn());
                
                return new ArrowTower(tower);
            }

            if (towerType == TowerTypes.Cannon)
            {
                var tower = new Tower(location);
                tower.SetSpwaner(new BombSpawn());
                
                return new CannonTower(tower);
            }

            return null;
        }
    }
}