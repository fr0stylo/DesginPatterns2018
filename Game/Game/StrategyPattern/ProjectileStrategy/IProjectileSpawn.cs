using System.Drawing;
using Game.Entities.Projectiles;

namespace Game.StrategyPattern.ProjectileStrategy
{
    public interface IProjectileSpawn
    {
        Projectile SpawnProjectile(PointF position);
    }
}