using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.FactoryPattern
{
    public interface IBaloon
    {
        void Move();

        Bitmap GetShape();

        PointF GetCurrentPosition();

        int GetSpeed();

        bool GetIsDead();

        void SetDead();
        
    }
}
