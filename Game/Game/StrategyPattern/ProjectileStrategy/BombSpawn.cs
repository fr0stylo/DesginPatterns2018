using System.Drawing;
using Game.Entities.Projectiles;

namespace Game.StrategyPattern.ProjectileStrategy
{
    public class BombSpawn : IProjectileSpawn
    {
        public Projectile SpawnProjectile(PointF position)
        {
            return new Bomb(position);
        }
    }
}