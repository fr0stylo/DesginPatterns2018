using System.Drawing;

namespace Game.Entities.Projectiles
{
    public class Arrow : Projectile
    {
        public Arrow(PointF initialPosition)
        {
            DamageRadius = 2;
            Speed = 10;
            InitialPosition = initialPosition;
        }
    }
}