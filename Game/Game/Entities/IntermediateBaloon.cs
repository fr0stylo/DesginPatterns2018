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
    class IntermediateBaloon : IBaloon
    {
        public readonly int health = 150;

        public readonly string type = "IntermediateBaloon";

        // don't go over 15 mate
        public readonly int speed = 10;

        public PointF position = new PointF(0, 0);

        public static Bitmap BaloonBitmap => Resources.YellowBaloon;

        public bool IsDead = false;

        public string GetBaloonType()
        {
            return type;
        }

        public PointF GetCurrentPosition()
        {
            return this.position;
        }

        public Bitmap GetShape()
        {
            return BaloonBitmap;
        }

        public int GetSpeed()
        {
            return speed;
        }
        
        public void Move(PointF position)
        {
            this.position = position;
        }

        public bool GetIsDead()
        {
            return IsDead;
        }

        public void SetDead()
        {
            IsDead = true;
        }
    }
}
