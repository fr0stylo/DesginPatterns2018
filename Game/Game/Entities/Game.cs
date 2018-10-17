using System;
using System.Collections.Generic;
using System.Drawing;
using Game.Input;

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
                var color = Color.FromArgb(Generator.Next(255), Generator.Next(255), Generator.Next(255),
                    Generator.Next(255));
                g.DrawLine(new Pen(color), point[0], point[1]);
            }

            var mouse = MouseInput.GetInstance();

            foreach (var point in mouse.DrawablePoints())
            {
                var color = Color.FromArgb(Generator.Next(255), Generator.Next(255), Generator.Next(255),
                    Generator.Next(255));
                g.DrawLine(Pens.BlueViolet, point[0], point[1]);
            }

            _points.Clear();
        }
    }
}