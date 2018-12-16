using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;
using Game.CompositePattern;
using Game.FactoryPattern;

namespace Game.Entities
{
    class PowerfulBaloon : Baloon
    {
        public static Bitmap BaloonBitmap => Resources.BlackBaloon;

        public PowerfulBaloon(bool isPlayer1Baloon)
        {
            Speed = 7;
            Damage = 10;
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

        public override void Add(Component item) { }
        public override void Remove(Component item) { }
        public override IBaloon GetChildren()
        {
            return this.baloon;
        }
    }
}
