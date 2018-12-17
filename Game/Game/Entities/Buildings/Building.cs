using System.Drawing;

namespace Game.Entities.Buildings
{
    public interface Building: IRenderable
    {
        int GetPrice();
        PointF GetPosition();
        void SetDisposed(bool disposed);
    }
}