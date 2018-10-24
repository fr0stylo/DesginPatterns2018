using Game.FactoryPattern;
using Game.Properties;
using System.Drawing;

namespace Game.Entities
{
    public class WeakBaloon:IBaloon
    {
        private readonly int health = 100;

        private readonly string type = "WeakBaloon";

        private static Bitmap BaloonBitmap => Resources.RedBaloon;

        // don't go over 15 mate
        private readonly int speed = 5;

        private  PointF position = new PointF(0, 0);

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
    }
}