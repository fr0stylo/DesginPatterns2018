using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using Game.BuilderPattern;
using Game.BuilderPattern.Waves;
using Game.Entities.Buildings;
using Game.Facade;
using Game.Input;
using Game.FactoryPattern;

namespace Game.Entities {
    public class Game : IGameFacade {
        private List<PointF[]> _points;
        private List<IRenderable> _entities;
        private int _width, _height;
        private GameStateSingleton _gameState = GameStateSingleton.GetInstance();
        private Timer waveCreator;
        private WaveDirector _waveDirector;

        public Game(int width, int height) {
            _width = width;
            _height = height;
            _points = new List<PointF[]>();
            _gameState.AddPlayer(new Player("Player 1 (you)"));
            _entities = new List<IRenderable>();
            _waveDirector = new WaveDirector();
            _waveDirector.SetBuilder(new FirstWave());

            waveCreator = new Timer(i => _generateWave(), null, 0, 10000);
        }

        private void _generateWave() {
            _waveDirector.BuildWave();
            _entities = _entities.Where(x => !x.IsDisposed()).ToList();
            _entities.Add(_waveDirector.GetVave);
            _waveDirector.NextWave();
        }

        public void Update() {}

        public void Render(System.Drawing.Graphics g) {
            foreach (var point in _points) {
                g.DrawImage(Tower.TowerBitmap, point);
            }

            foreach (var renderable in _entities) {
                renderable.Render(g);
            }
//            var currentPlayer = _gameState.GetCurrentPlayer();
//
//            foreach (var buildings in currentPlayer.GetBuildings())
//            {
//                g.DrawImage(Tower.TowerBitmap, buildings.GetPosition());
//            }
//
//            foreach (Baloon baloon in _gameState.GetPlayer1Baloons())
//            {
//                if (!baloon.GetIsDead())
//                {
//                    g.DrawImage(baloon.GetShape(), baloon.GetCurrentPosition());
//                    baloon.Move();
//                }
//                // while printing, dont allow to modify collection
//                _gameState.SetAllowAddPlayer1Baloons(false);
//            }
//            _gameState.SetAllowAddPlayer1Baloons(true);
//
//            foreach (Baloon baloon in _gameState.GetPlayer2Baloons())
//            {
//                if (!baloon.GetIsDead())
//                {
//                    g.DrawImage(baloon.GetShape(), baloon.GetCurrentPosition());
//                    baloon.Move();
//                }
//                // while printing, dont allow to modify collection
//                _gameState.SetAllowAddPlayer2Baloons(false);
//            }
//            _gameState.SetAllowAddPlayer2Baloons(true);
            _points.Clear();
        }
    }
}