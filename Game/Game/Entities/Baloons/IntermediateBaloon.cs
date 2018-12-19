using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;
using Game.CompositePattern;
using Game.FactoryPattern;

namespace Game.Entities
{
    class IntermediateBaloon : Baloon, IComponent
    {
        public static Bitmap BaloonBitmap => Resources.YellowBaloon;

        public IntermediateBaloon(bool isPlayer1Baloon)
        {
            Speed = 5;
            Damage = 20;
            IsPlayer1Baloon = isPlayer1Baloon;
            SpacingPoint = new PointF(70,70);

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
            this.Speed = 10;
        }

        public override void BackToDefaultSpeed()
        {
            this.Speed = 5;
        }

        public void Add(IComponent item){}
        public void Remove(IComponent item){}
        public dynamic GetChildren()
        {
            return this;
        }
    }
}
