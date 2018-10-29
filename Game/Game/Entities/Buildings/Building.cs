using System.Drawing;

namespace Game.Entities.Buildings
{
    public interface Building
    {
        int GetPrice();
        PointF GetPosition();
    }
}