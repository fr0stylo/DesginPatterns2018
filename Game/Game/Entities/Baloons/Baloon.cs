using Game.FactoryPattern;
using Game.PrototypePattern;
using Game.StrategyPattern;
using System;
using System.Drawing;

namespace Game.Entities
{
    public abstract class Baloon : IBaloon, IPrototype
    {
        protected int Damage;
        protected int Speed; 
        private bool IsDead = false;
        protected PointF Position = new PointF(0, 0);
        protected bool IsPlayer1Baloon;
        protected PointF SpacingPoint;

        public IMoveAlgorithm moveStrategy;

                
        public void Move()
        {
            var damagedPlayer = false;
            
            moveStrategy.Move(ref Position, Speed, ref damagedPlayer);

            if (damagedPlayer)
            {
                var currentPlayer = GameStateSingleton.GetInstance().GetCurrentPlayer();
                currentPlayer.DecreaseHealthPoints(Damage);
                IsDead = true;
            }
        }

        public abstract Bitmap GetShape();

        public PointF GetCurrentPosition()
        {
            return Position;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public bool GetIsDead()
        {
            return IsDead;
        }

        public void SetDead()
        {
            IsDead = true;
        }

        public void SetReleaseSpacing(int x, int y)
        {
            Position = new PointF(Position.X - SpacingPoint.X * x, Position.Y - SpacingPoint.Y * y);
        }

        IPrototype IPrototype.Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
