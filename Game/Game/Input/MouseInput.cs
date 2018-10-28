using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.FactoryPattern;
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

        public void HandleClick(Point location, TowerTypes towerType)
        {
            var towerMaker = new TowerFactory();
            var createdTower = towerMaker.MakeTower(towerType, location);
            
            _gameState.GetCurrentPlayer().AddTower(createdTower);
        }

        public static MouseInput GetInstance() {
            return _instance ?? (_instance = new MouseInput());
        }
    }
}