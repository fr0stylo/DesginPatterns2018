using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.FactoryPattern
{
    interface IBaloon
    {
        void Move(PointF position);

        Bitmap GetShape();

        PointF GetCurrentPosition();

        string GetBaloonType();

        int GetSpeed();
    }
}
