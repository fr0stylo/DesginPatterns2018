using System.Drawing;
using Game.Entities.Projectiles;
using Game.Properties;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities
{
    public class Tower
    {
        public static Bitmap TowerBitmap => Resources.Tower;
        
        private PointF Position;
        protected int GameId;
        protected int Price;
        protected IProjectileSpawn Spawner;

        protected Tower(PointF position)
        {
            Position = position;
        }

        public PointF GetPosition()
        {
            return Position;
        }

        public Projectile SpawnProjectile(PointF position)
        {
            return Spawner.SpawnProjectile(position);
        }
    }
}