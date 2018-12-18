using Game.VisitorPattern;

namespace Game.Facade
{
    public interface IGameFacade {
        void Update();
        void Render(IVisitor visitor);
    }
}
