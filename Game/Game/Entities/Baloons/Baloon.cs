using Game.Entities.Baloons;
using Game.FactoryPattern;
using Game.PrototypePattern;
using Game.StrategyPattern;
using System;
using System.Drawing;
using Game.Helpers.Enums;
using Game.VisitorPattern;

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
        protected BaloonTypes type;

        //private DebugLogSingleton _sigleton = DebugLogSingleton.GetInstance();

        public IMoveAlgorithm moveStrategy;

        public Baloon()
        {
        }
        public BaloonTypes GetBaloonType()
        {
            return type;
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

        public void SetDead(bool IsDead)
        {
            this.IsDead = IsDead;
        }

        public void SetReleaseSpacing(int x, int y)
        {
            Position = new PointF(Position.X - SpacingPoint.X * x, Position.Y - SpacingPoint.Y * y);
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
        public abstract void ChangeToSprintSpeed();

        public abstract void BackToDefaultSpeed();

        public virtual void SetDefaultValues()
        {
            Speed = 3;
            IsDead = false;
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

        public abstract void Accept(IVisitor visitor);
    }
}
