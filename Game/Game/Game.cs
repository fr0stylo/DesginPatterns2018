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
        private int _width, _height;
        private GameStateSingleton _gameState = GameStateSingleton.GetInstance();
        private Timer waveCreator;
        private WaveDirector _waveDirector;
        private DebugLogSingleton _singleton;
        private int _facadeCounter;

        public Game(int width, int height) {
            _width = width;
            _height = height;
            _points = new List<PointF[]>();
            _gameState.AddPlayer(new Player("Player 1 (you)"));
            _waveDirector = new WaveDirector();
            _waveDirector.SetBuilder(new FirstWave());
            _singleton = DebugLogSingleton.GetInstance();
            _singleton.Log<IGameFacade>("Facade", "IGameFacade method: Update use facade pattern.");
            waveCreator = new Timer(i => _generateWave(), null, 0, 10000);
            _facadeCounter = 0;
        }

        private void _generateWave() {
            _waveDirector.BuildWave();
            _gameState.AddRenderable(_waveDirector.GetWave);
            _waveDirector.NextWave();
        }

        public void Update() {
            if (_facadeCounter == 30000)
            {
                _facadeCounter = 0;
            }
            _facadeCounter++;
        }

        public void Render(System.Drawing.Graphics g) {

            foreach (var point in _points) {
                g.DrawImage(Tower.TowerBitmap, point);
            }

            foreach (var renderable in _gameState.GetRenderables()) {
                renderable.Render(g);
            }

            _points.Clear();
        }
    }
}