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
            Speed = 5;
            Damage = 20;
            IsPlayer1Baloon = isPlayer1Baloon;
            type = Helpers.Enums.BaloonTypes.Intermediate;
            SpacingPoint = new PointF(70,70);

            if (isPlayer1Baloon)
                moveStrategy = new Player1Movement();
            else
            {
                moveStrategy = new Player2Movement();
                Position.X = 675;
            }
        }
        public override void SetDefaultValues()
        {
            Speed = 5;
            SetDead(false);
            if (moveStrategy.GetType() == typeof(Player1Movement))
            {
                Position.X = 0;
                Position.Y = 0;
            }
            else
            {
                Position.X = 675;
                Position.Y = 0;
            }
        }
        public override Bitmap GetShape()
        {
            return BaloonBitmap;
        }

        public override void ChangeToSprintSpeed()
        {
            this.Speed = 10;
        }

        public override void BackToDefaultSpeed()
        {
            this.Speed = 5;
        }
    }
}
