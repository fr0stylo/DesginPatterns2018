using System.Drawing;

namespace Game.Entities.Buildings
{
    public abstract class TowerDecorator : Building
    {
        protected Building TempBuilding;

        public TowerDecorator(Building tempBuilding)
        {
            TempBuilding = tempBuilding;
        }

        public virtual int GetPrice()
        {
            return TempBuilding.GetPrice();
        }

        public PointF GetPosition()
        {
            return TempBuilding.GetPosition();
        }
    }
}