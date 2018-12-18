using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.FactoryPattern;
using Game.VisitorPattern;

namespace Game.BuilderPattern
{
    public class Wave: IRenderable
    {
        public int Number;
        public int Spacing;
        public List<Baloon> Baloons;

        public bool IsDisposed() {
            Baloons = Baloons.Where(x => !x.IsDisposed()).ToList();

            return Baloons.Count <= 0;
        }

        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}
