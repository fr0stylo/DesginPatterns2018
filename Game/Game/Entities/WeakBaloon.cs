using Game.FactoryPattern;
using Game.Properties;
using System.Drawing;

namespace Game.Entities
{
    public class WeakBaloon:IBaloon
    {
        public readonly int health = 100;

        public readonly string type = "WeakBaloon";

        public static Bitmap BaloonBitmap => Resources.RedBaloon;

        // don't go over 15 mate
        public readonly int speed = 5;

        public PointF position = new PointF(0, 0);

        public bool IsDead = false;

        public PointF GetCurrentPosition()
        {
            return this.position;
        }
        public void Move(PointF position)
        {
            this.position = position;
        }

        public Bitmap GetShape()
        {
            return BaloonBitmap;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public string GetBaloonType()
        {
            return type;
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