using System.Drawing;

namespace Game.Entities.Projectiles
{
    public class Projectile
    {
        protected int DamageRadius;
        protected int Speed;
        protected PointF InitialPosition;

        public int GetDamageRadius()
        {
            return DamageRadius;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public PointF GetInitialPosition()
        {
            return InitialPosition;
        }
    }
}