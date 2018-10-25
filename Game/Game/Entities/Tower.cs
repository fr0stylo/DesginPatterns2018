using System.Drawing;
using Game.Properties;

namespace Game.Entities
{
    public class Tower
    {
        public static Bitmap TowerBitmap => Resources.Tower;

        public PointF position { get; set; }

        public int GameId { get; set; }



    }
}