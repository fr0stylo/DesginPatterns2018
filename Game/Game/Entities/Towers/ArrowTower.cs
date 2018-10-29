using System.Drawing;
using Game.StrategyPattern.ProjectileStrategy;

namespace Game.Entities
{
    public class ArrowTower : Tower
    {
        public ArrowTower(PointF position) : base(position)
        {
            Spawner = new ArrowSpawn();
        }
    }
}