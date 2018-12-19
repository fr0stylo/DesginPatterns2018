using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;

namespace Game.CompositePattern
{
    public interface IComponent
    {
        void Add(IComponent item);
        void Remove(IComponent item);
        dynamic GetChildren();
    }
}
