using System.Drawing;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities
{
    public class CannonTower : Tower
    {
        public CannonTower(PointF position) : base(position)
        {
            Spawner = new BombSpawn();
        }
    }
}