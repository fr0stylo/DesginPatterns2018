using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using Game.BuilderPattern;
using Game.BuilderPattern.Waves;
using Game.Facade;
using Game.Input;
using Game.FactoryPattern;

namespace Game.Entities {
    public class Game: IGameFacade {
        private List<PointF[]> _points;
        private int _width, _height;
        private GameStateSingleton _gameState = GameStateSingleton.GetInstance();
        private List<IBaloon> waves;
        private Timer waveCreator;
        private WaveDirector _waveDirector;

        public Game(int width, int height) {
            _width = width;
            _height = height;
            _points = new List<PointF[]>();
            _gameState.AddPlayer(new Player("Player 1 (you)"));

            _waveDirector = new WaveDirector();
            _waveDirector.SetBuilder(new FirstWave());

            waveCreator = new Timer(i => _generateWave(), null, 0, 10000);

            waves = new List<IBaloon>();
        }

        private void _generateWave() {

            _waveDirector.BuildWave();

            waves.AddRange(_waveDirector.GetVave.Baloons);

            _waveDirector.NextWave();
        }

        public void Update() {
            
        }

        public void Render(System.Drawing.Graphics g) {
            foreach (var point in _points) {
                g.DrawImage(Tower.TowerBitmap, point);
            }

            var currentPlayer = _gameState.GetCurrentPlayer();

            foreach (var tower in currentPlayer.GetTowers())
            {
                g.DrawImage(Tower.TowerBitmap, tower.Position);
            }

            foreach (Baloon baloon in waves.ToList())
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