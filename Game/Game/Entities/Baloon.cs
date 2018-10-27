using Game.FactoryPattern;
using Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public abstract class Baloon : IBaloon
    {
        public PointF position = new PointF(0, 0);

        public bool IsDead = false;

        public abstract void Move(PointF position);

        public abstract Bitmap GetShape();

        public abstract PointF GetCurrentPosition();

        public abstract string GetBaloonType();

        public abstract int GetSpeed();

        public abstract bool GetIsDead();

        public abstract void SetDead();
    }
}
