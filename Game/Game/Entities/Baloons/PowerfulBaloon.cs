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
            Speed = 7;
            Damage = 10;
            type = Helpers.Enums.BaloonTypes.Powerful;
            IsPlayer1Baloon = isPlayer1Baloon;
            SpacingPoint = new PointF(100, 100);

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
            Speed = 7;
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
            this.Speed = 12;
        }

        public override void BackToDefaultSpeed()
        {
            this.Speed = 7;
        }
    }
}
