using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;
using Game.VisitorPattern;

namespace Game.Entities
{
    public class WeakBaloon : Baloon
    {
        public WeakBaloon(bool isPlayer1Baloon)
        {
            Speed = 3;
            Damage = 1;
            IsPlayer1Baloon = isPlayer1Baloon;
            type = Helpers.Enums.BaloonTypes.Weak;
            SpacingPoint = new PointF(50, 50);

            if (isPlayer1Baloon)
                moveStrategy = new Player1Movement();
            else
            {
                moveStrategy = new Player2Movement();
                Position.X = 675;
            }
        }

        public override void ChangeToSprintSpeed()
        {
            Speed = 5;
        }

        public override void BackToDefaultSpeed()
        {
            Speed = 3;
        }

        public override void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
    }
}
