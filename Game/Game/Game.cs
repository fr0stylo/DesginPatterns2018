using System;
using System.Collections.Generic;
using System.Drawing;
using Game.Input;
using Game.FactoryPattern;

namespace Game.Entities {
    public class Game {
        private List<PointF[]> _points;
        private int _width, _height;
        private GameStateSingleton gameState = GameStateSingleton.GetInstance();
        public Game(int width, int height) {
            _width = width;
            _height = height;
            _points = new List<PointF[]>();
            gameState.AddPlayer(new Player("Player 1 (you)"));
        }

        public void Update() {}

        public void Render(System.Drawing.Graphics g) {
            foreach (var point in _points) {
                g.DrawImage(Tower.TowerBitmap, point);
            }

            var mouse = MouseInput.GetInstance();

            foreach (var point in mouse.DrawablePoints())
            {
                g.DrawImage(Tower.TowerBitmap, point[0]);
            }
            var baloons = BaloonFactory.GetInstance(true);

            foreach (Baloon baloon in baloons.Baloons())
            {
                if (!baloon.GetIsDead())
                {
                    g.DrawImage(baloon.GetShape(), baloon.GetCurrentPosition());
                    baloon.Move();
                }
            }

            _points.Clear();
        }
    }
}