using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;
using Game.CompositePattern;
using Game.FactoryPattern;

namespace Game.Entities
{
    public class WeakBaloon : Baloon
    {
        private static Bitmap BaloonBitmap => Resources.RedBaloon;

        public WeakBaloon(bool isPlayer1Baloon)
        {
            Speed = 3;
            Damage = 1;
            IsPlayer1Baloon = isPlayer1Baloon;
            SpacingPoint = new PointF(50, 50);

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

        public override void Add(Component item) { }
        public override void Remove(Component item) { }
        public override IBaloon GetChildren()
        {
            return this.baloon;
        }
    }
}
