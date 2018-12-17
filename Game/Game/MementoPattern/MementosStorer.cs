using System.Collections.Generic;

namespace Game.MementoPattern
{
    public class MementosStorer
    {
        private Stack<Memento> _mementos;

        public MementosStorer()
        {
            _mementos = new Stack<Memento>();
        }

        public void AddMemento(Memento memento)
        {
            _mementos.Push(memento);
        }

        public Memento PopMemento()
        {
            return _mementos.Pop();
        }
    }
}