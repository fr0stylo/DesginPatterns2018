using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;

namespace Game.Entities
{
    class IntermediateBaloon : Baloon
    {
        public static Bitmap BaloonBitmap => Resources.YellowBaloon;

        public IntermediateBaloon(bool isPlayer1Baloon)
        {
            Speed = 10;
            Damage = 20;
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
