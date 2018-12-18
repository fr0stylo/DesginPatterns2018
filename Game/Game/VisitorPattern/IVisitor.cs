using Game.BuilderPattern;
using Game.Entities;
using Game.Entities.Buildings;

namespace Game.VisitorPattern
{
    public interface IVisitor {
        void Visit(WeakBaloon bloon);
        void Visit(Baloon bloon);
        void Visit(IntermediateBaloon bloon);
        void Visit(PowerfulBaloon bloon);
        void Visit(ArrowTower tower);
        void Visit(Tower tower);
        void Visit(Building b);
        void Visit(CannonTower tower);
        void Visit(Wave wave);
    }
}
