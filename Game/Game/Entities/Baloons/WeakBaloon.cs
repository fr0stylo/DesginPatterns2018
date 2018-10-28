using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;

namespace Game.Entities
{
    public class WeakBaloon : Baloon
    {
        private static Bitmap BaloonBitmap => Resources.RedBaloon;

        public WeakBaloon(bool isPlayer1Baloon)
        {
            Speed = 5;
            Damage = 1;
            IsPlayer1Baloon = isPlayer1Baloon;
            SpacingPoint = new PointF(50, 50);

            if (isPlayer1Baloon)
                moveStrategy = new Player1Movement();
            else
                moveStrategy = new Player2Movement();
        }

        public override Bitmap GetShape()
        {
            return BaloonBitmap;
        }
    }
}