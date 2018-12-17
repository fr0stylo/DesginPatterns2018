using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.IteratorPattern {
    public interface IIteratable<T> where T: class {
        T First();
        void Add(T t);
        bool HasNext();
        T Next();
        void Remove(T t);
    }
}