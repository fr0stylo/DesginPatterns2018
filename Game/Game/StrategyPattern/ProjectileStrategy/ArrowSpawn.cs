using System.Drawing;
using Game.Entities.Projectiles;

namespace Game.StrategyPattern.ProjectileStrategy
{
    public class ArrowSpawn : IProjectileSpawn
    {
        public Projectile SpawnProjectile(PointF position)
        {
            return new Arrow(position);
        }
    }
}