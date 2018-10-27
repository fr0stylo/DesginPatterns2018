using System.Drawing;
using Game.Properties;

namespace Game.Entities
{
    public class Tower
    {
        public static Bitmap TowerBitmap => Resources.Tower;
        public PointF Position { get; set; }
        public int GameId { get; set; }
        public int Price { get; set; }

        public Tower(PointF position)
        {
            Position = position;
        }
    }
}