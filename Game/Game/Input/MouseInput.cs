using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities.Buildings;
using Game.Entities;
using Game.FactoryPattern;
using Game.Helpers.Enums;
using Game.Command;

namespace Game.Input {
    public class MouseInput : MouseSubject {
        private List<Point> lastMouseUp;
        private List<Point> lastMouseDown;
        private List<Point> clickPosition;
        private GameStateSingleton _gameState = GameStateSingleton.GetInstance();
        private static MouseInput _instance;
        private string _mouseState;

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

        public void HandleClick(TowerFactory factory, Point location, TowerTypes towerType)
        {
            ICommand command = new TowerCommand(factory, location, towerType);
            _gameState.AddRenderable(command.Execute());
        }

        public void HandleClick(BaloonFactory baloonFactory, BaloonTypes baloonType)
        {
            ICommand command = new BaloonCommand(baloonFactory, baloonType);
            IBaloon baloon = command.Execute();
            if(baloon != null)
            _gameState.AddRenderable(baloon);
        }

        public static MouseInput GetInstance() {
            return _instance ?? (_instance = new MouseInput());
        }

        public string MouseState
        {
            get { return _mouseState; }
            set { _mouseState = value; }
        }
    }
}