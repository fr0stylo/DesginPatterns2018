using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;

namespace Game.CompositePattern
{
    public abstract class Component
    {
        public IBaloon baloon;

        public abstract void Add(Component item);
        public abstract void Remove(Component item);
        public abstract IBaloon GetChildren();
    }
}
