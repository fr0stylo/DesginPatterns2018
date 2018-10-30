using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public interface IRenderable {
        void Render(System.Drawing.Graphics g);
        bool IsDisposed();
    }
}
