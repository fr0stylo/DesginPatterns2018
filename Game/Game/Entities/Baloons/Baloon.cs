using Game.FactoryPattern;
using Game.Properties;
using Game.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public abstract class Baloon : IBaloon
    {
        protected int Damage;
        protected int Speed; 
        private bool IsDead = false;
        protected PointF Position = new PointF(0, 0);
        protected bool IsPlayer1Baloon;

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


    }
}
