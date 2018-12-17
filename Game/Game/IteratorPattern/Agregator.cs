using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.IteratorPattern
{
    public abstract class Agregator<T>: IIteratable<T> where T : class { 
        public abstract IIteratable<T> CreateIterator();
        public abstract T First();
        public abstract void Add(T t);
        public abstract bool HasNext();
        public abstract T Next();
        public abstract void Remove(T t);
        public abstract List<T> ToList();
        public abstract Agregator<T> FromList(List<T> list);
    }
}
