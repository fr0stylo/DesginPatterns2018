using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.FactoryPattern;
using Game.CompositePattern;

namespace Game.BuilderPattern
{
    public class Wave: IRenderable
    {
        public int Number;
        public int Spacing;
        public IComponent Baloons = new Composite();

        public void Render(System.Drawing.Graphics g) {
            foreach (var baloon in Baloons.GetChildren())
            {
                baloon.Render(g);
            }
        }

        public bool IsDisposed() {
            return Baloons.Equals(null);
        }
    }
}
