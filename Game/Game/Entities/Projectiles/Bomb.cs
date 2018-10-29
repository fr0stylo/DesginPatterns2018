using System.Drawing;

namespace Game.Entities.Projectiles
{
    public class Bomb : Projectile
    {
        public Bomb(PointF initialPosition)
        {
            DamageRadius = 7;
            Speed = 5;
            InitialPosition = initialPosition;
        }
    }
}