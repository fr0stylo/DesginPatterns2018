using System.Collections.Generic;
using System.Linq;

namespace Game.IteratorPattern
{
    class HashIterator<T> : Agregator<T> where T : class {
        private Dictionary<int, T> hashMap;
        private int index;

        public HashIterator() {
            hashMap = new Dictionary<int, T>();    
        }

        public override IIteratable<T> CreateIterator() {
            return this;
        }

        public override T First() {
            index = 0;
            return hashMap[hashMap.Keys.ToArray()[0]];
        }

        public override void Add(T t) {
            index = 0;
            hashMap.Add(t.GetHashCode(), t);
        }

        public override bool HasNext() {
            return index < hashMap.Keys.Count;
        }

        public override T Next() {
            return hashMap[hashMap.Keys.ToArray()[index++]];
        }

        public override void Remove(T t) {
            hashMap.Remove(t.GetHashCode());
        }

        public override Agregator<T> FromList(List<T> list) {
            hashMap = new Dictionary<int, T>();
            foreach (var item in list) {
                Add(item);
            }

            return this;
        }

        public override List<T> ToList() {
            return hashMap.Values.ToList();
        }
    }
}
