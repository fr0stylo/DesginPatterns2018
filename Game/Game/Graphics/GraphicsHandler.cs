using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Game.Properties;

namespace Game.Graphics
{
    public class GraphicsHandler {
        private System.Drawing.Graphics _graphics;

        public GraphicsHandler(System.Drawing.Graphics graphics, Color baseColor) {
            _graphics = graphics;
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _graphics.CompositingMode = CompositingMode.SourceOver;
            _graphics.InterpolationMode = InterpolationMode.Bicubic;

            _graphics.Clear(baseColor);
        }

        public void Render(Entities.Game game) {
            _graphics.DrawImage(new Entities.Map().MapBitmap, new Point(0, 0));
            
            game.Render(_graphics);
        }
    }
}
