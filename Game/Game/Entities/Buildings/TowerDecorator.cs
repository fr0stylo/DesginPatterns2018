using System.Drawing;
using Game.VisitorPattern;

namespace Game.Entities.Buildings
{
    public abstract class TowerDecorator : Building
    {
        protected Building TempBuilding;
        private DebugLogSingleton _singleton = DebugLogSingleton.GetInstance();

        protected TowerDecorator(Building tempBuilding)
        {
            TempBuilding = tempBuilding;
            _singleton.Log<TowerDecorator>("Decorator", "Initializing tower decorator.");
        }

        public virtual int GetPrice()
        {
            return TempBuilding.GetPrice();
        }

        public PointF GetPosition()
        {
            return TempBuilding.GetPosition();
        }

        public bool IsDisposed() {
            return TempBuilding.IsDisposed();
        }
        
        public void SetDisposed(bool disposed)
        {}

        public void Accept(IVisitor visitor) {
            visitor.Visit(TempBuilding);
        }
    }
}