using Game.FactoryPattern;
using Game.Properties;
using System.Drawing;

namespace Game.Entities
{
    public class WeakBaloon: Baloon
    {
        public readonly int health = 100;

        public readonly string type = "WeakBaloon";

        public static Bitmap BaloonBitmap => Resources.RedBaloon;

        // don't go over 15 mate
        public readonly int speed = 5;


        public override PointF GetCurrentPosition()
        {
            return this.position;
        }
        public override void Move(PointF position)
        {
            this.position = position;
        }

        public override Bitmap GetShape()
        {
            return BaloonBitmap;
        }

        public override int GetSpeed()
        {
            return speed;
        }

        public override string GetBaloonType()
        {
            return type;
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