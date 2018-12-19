using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;

namespace Game.CompositePattern
{
    public class Composite : IComponent
    {
        public List<IComponent> children = new List<IComponent>();

        public void Add(IComponent item)
        {
            children.Add(item);
        }
        public void Remove(IComponent item)
        {
            children.Remove(item);
        }
        public dynamic GetChildren()
        {
            List<IBaloon> help = new List<IBaloon>();
            foreach (var child in children)
            {
                help.Add((IBaloon)child);
            }
            return help;
        }
    }
}
