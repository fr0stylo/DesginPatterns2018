using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.FactoryPattern;

namespace Game.BuilderPattern
{
    public class Wave: IRenderable
    {
        public int Number;
        public int Spacing;
        public List<IBaloon> Baloons;

        public void Render(System.Drawing.Graphics g) {
            foreach (var baloon in Baloons) {
                baloon.Render(g);
            }
        }

        public bool IsDisposed() {
            Baloons = Baloons.Where(x => !x.IsDisposed()).ToList();

            return Baloons.Count <= 0;
        }
    }
}
