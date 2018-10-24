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
    class PowerfulBaloon : IBaloon
    {
        private readonly int health = 300;

        private readonly string type = "PowerfulBaloon";
       
        // don't go over 15 mate
        private readonly int speed = 15;

        private PointF position = new PointF(0, 0);

        private static Bitmap BaloonBitmap => Resources.BlackBaloon;

        public int GetSpeed()
        {
            return speed;
        }

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

        public void Move(PointF position)
        {
            this.position = position;
        }

       
    }
}
