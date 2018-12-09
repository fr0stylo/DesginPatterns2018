using Game.Entities.Baloons;
using Game.FactoryPattern;
using Game.PrototypePattern;
using Game.StrategyPattern;
using System;
using System.Drawing;

namespace Game.Entities
{
    public abstract class Baloon : MasterBaloon, IBaloon
    {
        protected int Damage;
        protected int Speed; 
        private bool IsDead = false;
        protected PointF Position = new PointF(0, 0);
        protected bool IsPlayer1Baloon;
        protected PointF SpacingPoint;
        //private DebugLogSingleton _sigleton = DebugLogSingleton.GetInstance();

        public IMoveAlgorithm moveStrategy;

        public Baloon()
        {
        }

        public void Move()
        {
            var damagedPlayer = false;

            Sprint();
            //_sigleton.Log<Baloon>("Strategy", "Baloon class call move strategy for baloon.");
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


        public void Render(System.Drawing.Graphics g) {
            if (GetIsDead()) return;
            g.DrawImage(GetShape(), GetCurrentPosition());
            Move();
        }

        public bool IsDisposed() {
            return IsDead;
        }
 
        IPrototype IPrototype.Clone()
        {
            return (IBaloon)this.MemberwiseClone();
        }

        public override sealed void Sprint()
        {
            if (((GetCurrentPosition().X > 100 && GetCurrentPosition().Y < 150 && moveStrategy.GetType() == typeof(Player1Movement))
                || (GetCurrentPosition().X > 750 && GetCurrentPosition().Y < 150 && moveStrategy.GetType() == typeof(Player2Movement)))
                && (this.GetType() == typeof(PowerfulBaloon) || this.GetType() == typeof(IntermediateBaloon)))
            {
                ChangeToSprintSpeed();
            }
            else
            {
                BackToDefaultSpeed();
            }              
        }
        public virtual void ChangeToSprintSpeed()
        {
        }
        public virtual void BackToDefaultSpeed()
        {
        }
    }
}
