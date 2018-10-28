using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Facade
{
    public interface IGameFacade {
        void Update();
        void Render(System.Drawing.Graphics g);
    }
}
