using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.Helpers.Enums;

namespace Game.Input {
    public class MouseInput {
        private List<Point> lastMouseUp;
        private List<Point> lastMouseDown;
        private List<Point> clickPosition;
        private GameStateSingleton _gameState = GameStateSingleton.GetInstance();

        private static MouseInput _instance;

        private MouseInput() {
            lastMouseDown = new List<Point>();
            lastMouseUp = new List<Point>();
            clickPosition = new List<Point>();
        }

        public void HandleDragStart(Point location) {
            lastMouseDown.Add(location);
        }

        public void HandleDragEnd(Point location) {
            lastMouseUp.Add(location);
        }

        public void HandleClick(Point location, TowerTypes towerType) {
            clickPosition.Add(location);
        }

        public List<PointF[]> DrawablePoints() {
            var result = lastMouseUp.Select((t, i) => new PointF[] {new PointF(lastMouseDown[i].X, lastMouseDown[i].Y), new PointF(t.X, t.Y),}).ToList();

            for (int i = 1; i < clickPosition.Count; i++) {
                result.Add(new PointF[] { new PointF(clickPosition[i-1].X, clickPosition[i-1].Y), new PointF(clickPosition[i].X, clickPosition[i].Y), });
            }

            return result;
        }

        public static MouseInput GetInstance() {
            return _instance ?? (_instance = new MouseInput());
        }
    }
}