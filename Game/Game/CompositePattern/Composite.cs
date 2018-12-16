using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;

namespace Game.CompositePattern
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public override void Add(Component item)
        {
            children.Add(item);
        }
        public override void Remove(Component item)
        {
            children.Remove(item);
        }
        public override IBaloon GetChildren()
        {
            if (children.Count == 1)
            {
                for (int i = 0; i <= children.Count - 1; i++)
                {
                    children[i].GetChildren();
                }
            }

            return children.Last().GetChildren();
        }
    }
}
