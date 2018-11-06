using System.Drawing;

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

        public void Render(System.Drawing.Graphics g) {
            TempBuilding.Render(g);
        }

        public bool IsDisposed() {
            return false;
        }
    }
}