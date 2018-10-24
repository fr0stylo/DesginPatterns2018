using System;
using System.Collections.Generic;
using System.Drawing;
using Game.Input;
using Game.FactoryPattern;

namespace Game.Entities {
    public class Game {
        private List<PointF[]> _points;
        private int _width, _height;
        private Random Generator = new Random(156816);
        private GameStateSingleton gameState = GameStateSingleton.getInstance();
        public Game(int width, int height) {
            _width = width;
            _height = height;
            _points = new List<PointF[]>();
            gameState.AddPlayer(new Player("Player 1 (you)"));
        }

        public void Update() {
//            _points.Add(new[] {
//                new PointF(Generator.Next(_width), Generator.Next(_height)),
//                new PointF(Generator.Next(_width), Generator.Next(_height))
//            });
        }

        public void Render(System.Drawing.Graphics g) {
            foreach (var point in _points) {
                g.DrawImage(Tower.TowerBitmap, point);
            }

            var mouse = MouseInput.GetInstance();

            foreach (var point in mouse.DrawablePoints())
            {
                g.DrawImage(Tower.TowerBitmap, point[0]);
            }
            var baloons = BaloonFactory.GetInstance();

            foreach (IBaloon baloon in baloons.Baloons())
            {
                g.DrawImage(baloon.GetShape(), baloon.GetCurrentPosition());

                int stepSize = baloon.GetSpeed();
               

                PointF currentPosition = baloon.GetCurrentPosition();
                // first line right
                if (currentPosition.X < 135 && currentPosition.Y == 0)
                    currentPosition.X += stepSize;
                //second line down
                else if (currentPosition.X >= 135 && currentPosition.X <= 150 && currentPosition.Y < 105)
                    currentPosition.Y += stepSize;
                //third line right
                else if (currentPosition.X >= 135 && currentPosition.X < 240 && currentPosition.Y >= 105 && currentPosition.Y <= 125)
                    currentPosition.X += stepSize;
                //fourth line up
                else if (currentPosition.X >= 240 && currentPosition.X <= 255 && currentPosition.Y > 0 && currentPosition.Y <= 125)
                    currentPosition.Y -= stepSize;
                //fifth line right
                else if (currentPosition.X >= 240 && currentPosition.X <= 365 && currentPosition.Y <= 0)
                    currentPosition.X += stepSize;
                // sixth line down 
                else if (currentPosition.X > 365 && currentPosition.X <= 380 && currentPosition.Y < 210)
                    currentPosition.Y += stepSize;
                // seventh line left
                else if (currentPosition.X > 240 && currentPosition.X <= 380 && currentPosition.Y >= 210 && currentPosition.Y <= 225)
                    currentPosition.X -= stepSize;
                // eight line down 
                else if (currentPosition.X <= 240 && currentPosition.Y >= 210 && currentPosition.Y < 390)
                    currentPosition.Y += stepSize;
                // ninth line right 
                else if (currentPosition.X > 230 && currentPosition.X < 365 && currentPosition.Y >= 390)
                    currentPosition.X += stepSize;
                // tenth line top 
                else if (currentPosition.X >= 365 && currentPosition.X < 400 && currentPosition.Y > 285 && currentPosition.Y <= 400)
                    currentPosition.Y -= stepSize;
                // eleventh line left 
                else if (currentPosition.X >= 365 && currentPosition.X < 490 && currentPosition.Y >= 280)
                    currentPosition.X += stepSize;
                // tvelve line down 
                else if (currentPosition.X >= 490 && currentPosition.Y >= 280 && currentPosition.Y < 400)
                    currentPosition.Y += stepSize;
                // last line left
                else if (currentPosition.X >= 490 && currentPosition.X <= 700 && currentPosition.Y >= 400)
                    currentPosition.X += stepSize;
                    
                baloon.Move(currentPosition);

            }

            _points.Clear();
        }
    }
}