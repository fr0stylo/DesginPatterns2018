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
    class IntermediateBaloon : Baloon
    {
        public readonly int health = 150;

        public readonly string type = "IntermediateBaloon";

        // don't go over 15 mate
        public readonly int speed = 10;

        public static Bitmap BaloonBitmap => Resources.YellowBaloon;

        public override string GetBaloonType()
        {
            return type;
        }

        public override PointF GetCurrentPosition()
        {
            return this.position;
        }

        public override Bitmap GetShape()
        {
            return BaloonBitmap;
        }

        public override int GetSpeed()
        {
            return speed;
        }
        
        public override void Move(PointF position)
        {
            this.position = position;
        }

        public override bool GetIsDead()
        {
            return IsDead;
        }

        public override void SetDead()
        {
            IsDead = true;
        }
    }
}
