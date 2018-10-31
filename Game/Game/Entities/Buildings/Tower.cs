using System.Drawing;
using Game.Entities.Projectiles;
using Game.Properties;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities.Buildings {
    public class Tower : Building {
        public static Bitmap TowerBitmap => Resources.Tower;

        private PointF Position;
        protected int GameId;
        protected int Price;
        protected IProjectileSpawn Spawner;

        public Tower(PointF position) {
            Position = position;
        }

        public PointF GetPosition() {
            return Position;
        }

        public void SetSpwaner(IProjectileSpawn spawner) {
            Spawner = spawner;
        }

        public Projectile SpawnProjectile(PointF position) {
            return Spawner.SpawnProjectile(position);
        }

        public int GetPrice() {
            return 10;
        }


        public void Render(System.Drawing.Graphics g) {
            g.DrawImage(TowerBitmap, GetPosition());
        }

        public bool IsDisposed() {
            return false;
        }
    }
}