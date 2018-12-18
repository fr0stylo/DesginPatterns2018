using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.BuilderPattern;
using Game.Entities;
using Game.Entities.Buildings;
using Game.Properties;

namespace Game.VisitorPattern {
    class RenderVisitor : IVisitor {
        private System.Drawing.Graphics renderer;

        public RenderVisitor(System.Drawing.Graphics g) {
            renderer = g;
        }

        public void Visit(WeakBaloon bloon) {
            if (bloon.GetIsDead()) return;
            renderer.DrawImage(Resources.RedBaloon, bloon.GetCurrentPosition());
            bloon.Move();
        }

        public void Visit(IntermediateBaloon bloon) {
            if (bloon.GetIsDead()) return;
            renderer.DrawImage(Resources.YellowBaloon, bloon.GetCurrentPosition());
            bloon.Move();
        }

        public void Visit(PowerfulBaloon bloon) {
            if (bloon.GetIsDead()) return;
            renderer.DrawImage(Resources.BlackBaloon, bloon.GetCurrentPosition());
            bloon.Move();
        }

        public void Visit(Baloon bloon)
        {
            if (bloon.GetIsDead()) return;
            renderer.DrawImage(Resources.BlackBaloon, bloon.GetCurrentPosition());
            bloon.Move();
        }


        public void Visit(ArrowTower tower) {
            renderer.DrawImage(Resources.Tower, tower.GetPosition());
        }

        public void Visit(Tower tower) {
            renderer.DrawImage(Resources.Tower, tower.GetPosition());
        }

        public void Visit(CannonTower tower) {
            renderer.DrawImage(Resources.Tower, tower.GetPosition());
        }

        public void Visit(Building b)
        {
            renderer.DrawImage(Resources.Tower, b.GetPosition());
        }

        public void Visit(Wave wave) {
            foreach (var bloon in wave.Baloons) {
                this.Visit(bloon);
            }
        }
    }
}