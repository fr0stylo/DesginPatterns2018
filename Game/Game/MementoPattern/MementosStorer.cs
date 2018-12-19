using System.Collections.Generic;

namespace Game.MementoPattern
{
    public class MementosStorer
    {
        private DebugLogSingleton _logSingleton;
        public Stack<Memento> _mementos { get; }

        public MementosStorer()
        {
            _mementos = new Stack<Memento>();
            _logSingleton = DebugLogSingleton.GetInstance();
        }

        public void AddMemento(Memento memento)
        {
            _logSingleton.Log<Memento>("Memento", $"Adding memento - towers count {memento.GetTowers().ToList().Count}");
            _mementos.Push(memento);
        }

        public Memento PopMemento()
        {
            var popedMemento = _mementos.Pop();
            _logSingleton.Log<Memento>("Memento", $"Use memento - towers count {popedMemento.GetTowers().ToList().Count}");
            return popedMemento;
        }
    }
}