using Game.Entities;
using Game.IteratorPattern;

namespace Game.MementoPattern
{
    public class Memento
    {
        private Agregator<IRenderable> _towers;

        public Memento(Agregator<IRenderable> towers)
        {
            _towers = towers;
        }

        public Agregator<IRenderable> GetTowers()
        {
            return _towers;
        }
    }
}