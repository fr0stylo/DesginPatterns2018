using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Game.Facade;
using Game.Properties;

namespace Game.Graphics
{
    public class GraphicsHandler
    {
        private System.Drawing.Graphics _graphics;

        private BufferedGraphicsContext context;
        private BufferedGraphics grafx;
        private int count= 0;
        private readonly int Width;
        private readonly int Height;

        public GraphicsHandler(System.Drawing.Graphics graphics, Color baseColor)
        {
            _graphics = graphics;
            _graphics.SmoothingMode = SmoothingMode.HighSpeed;
            _graphics.CompositingMode = CompositingMode.SourceCopy;
            _graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            _graphics.Clear(baseColor);
        }

        public GraphicsHandler(System.Drawing.Graphics createGraphics, Color baseColor, int width, int height)
        {
            _graphics = createGraphics;
            _graphics.SmoothingMode = SmoothingMode.HighSpeed;
            _graphics.CompositingMode = CompositingMode.SourceCopy;
            _graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            context = BufferedGraphicsManager.Current;
            context.MaximumBuffer = new Size(width + 1, height + 1);
            Height = height;
            Width = width;
            
            grafx = context.Allocate(createGraphics, 
                new Rectangle( 0, 0, width, height ));
        }

        public void Render(IGameFacade game)
        {
            DrawToBuffer(grafx.Graphics, game);
            grafx.Render(_graphics);
        }
        
        private void DrawToBuffer(System.Drawing.Graphics g, IGameFacade game)
        {
            if( ++count > 5 )
            {
                count = 0;                
                grafx.Graphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            }

            g.DrawImage(new Entities.Map().MapBitmap, new Point(0, 0));

            game.Render(g);
        }

    }
}