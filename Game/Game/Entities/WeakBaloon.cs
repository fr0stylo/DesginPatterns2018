using Game.FactoryPattern;
using Game.Properties;
using Game.StrategyPattern;
using System.Drawing;

namespace Game.Entities
{
    public class WeakBaloon: Baloon
    {
        public readonly int health = 100;

        public readonly string type = "WeakBaloon";

        public static Bitmap BaloonBitmap => Resources.RedBaloon;

        // don't go over 15 mate
        public readonly int speed = 5;

        public bool isPlayer1Baloon;

        public WeakBaloon(bool isPlayer1Baloon)
        {
            this.isPlayer1Baloon = isPlayer1Baloon;

            if(isPlayer1Baloon)
              moveStrategy = new Player1Movement();
            else
                moveStrategy = new Player2Movement();

        }
        public override PointF GetCurrentPosition()
        {
            return this.position;
        }
        public override void Move()
        {
            moveStrategy.Move(ref position, speed,ref isDead);
        }

        public override Bitmap GetShape()
        {
            return BaloonBitmap;
        }

        public override int GetSpeed()
        {
            return speed;
        }

        public override string GetBaloonType()
        {
            return type;
        }

        public override bool GetIsDead()
        {
            return isDead;
        }

        public override void SetDead()
        {
            isDead = true;
        }
    }
}