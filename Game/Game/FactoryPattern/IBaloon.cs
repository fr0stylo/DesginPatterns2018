using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.PrototypePattern;
using Game.Helpers.Enums;

namespace Game.FactoryPattern
{
    public interface IBaloon: IRenderable, IPrototype
    {
        void Move();

        Bitmap GetShape();

        PointF GetCurrentPosition();

        int GetSpeed();

        bool GetIsDead();

        void SetDead(bool IsDead);

        void SetReleaseSpacing(int x, int y);

        BaloonTypes GetBaloonType();

        void SetDefaultValues();

    }
}
