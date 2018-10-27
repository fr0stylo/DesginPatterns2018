using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.StrategyPattern
{
    public interface IMoveAlgorithm
    {
        void Move(ref PointF position, int speed, ref bool isDead);
    }
}
