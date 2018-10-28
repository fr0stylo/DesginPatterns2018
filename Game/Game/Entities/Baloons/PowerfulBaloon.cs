using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;

namespace Game.Entities
{
    class PowerfulBaloon : Baloon
    {
        public static Bitmap BaloonBitmap => Resources.BlackBaloon;

        public PowerfulBaloon(bool isPlayer1Baloon)
        {
            Speed = 15;
            Damage = 10;
            IsPlayer1Baloon = isPlayer1Baloon;

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