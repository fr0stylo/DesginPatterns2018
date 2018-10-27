using System.Drawing;
using Game.Entities;
using Game.Helpers.Enums;

namespace Game.FactoryPattern
{
    public class TowerFactory
    {
        public Tower MakeTower(TowerTypes towerType, Point location)
        {
            if (towerType == TowerTypes.Arrow)
                return new ArrowTower(location);;

            if (towerType == TowerTypes.Cannon)
                return new CannonTower(location);

            return null;
        }
    }
}