using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.IteratorPattern
{
    public class ListItertor<T>: Agregator<T> where T : class {
        private LinkedList<T> list;
        private LinkedListNode<T> current;
        private int position = -1;
        
        public ListItertor() {
            list = new LinkedList<T>();
        }

        public override IIteratable<T> CreateIterator() {
            return this;
        }

        public override T First() {
            //DebugLogSingleton.GetInstance().Log<ListItertor<T>>("Iterator", "First()");
            position = 0;
            current = list.First;
            return list.First.Value;
        }

        public override void Add(T t) {
            list.AddLast(t);
        }

        public override bool HasNext() {
            //DebugLogSingleton.GetInstance().Log<ListItertor<T>>("Iterator", "HasNext()");
            return position < list.Count-1;
        }

        public override T Next() {
            //DebugLogSingleton.GetInstance().Log<ListItertor<T>>("Iterator", "Next()");

            position++;
            current = current.Next;

            return current.Value;
        }

        public override void Remove(T t) {
            list.Remove(t);
        }

        public override Agregator<T> FromList(List<T> list) {
            this.list = new LinkedList<T>(list);
            return this;
        }

        public override List<T> ToList() {
            return list.ToList();
        }
    }
}
