using Game.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Game.Entities.Buildings;
using Game.GameState;
using Game.IteratorPattern;

namespace Game.Entities
{
    public class GameStateSingleton : IGameStateObserver
    {
        private int Id;
        private List<Player> Players;
        private BaloonFactory _baloonFactory;
        private bool AllowAddPlayer1Baloons;
        private bool AllowAddPlayer2Baloons;
        private bool InConstructionMode;
        private int Level;
        private Agregator<IRenderable> _entities;
        private DebugLogSingleton _singleton;

        private static class SingletonHolder
        {
            public static readonly GameStateSingleton _instance = new GameStateSingleton();
        }

        private GameStateSingleton()
        {
            Players = new List<Player>();
            _entities = new ListItertor<IRenderable>();
            AllowAddPlayer1Baloons = true;
            AllowAddPlayer2Baloons = true;
            InConstructionMode = false;
            _singleton = DebugLogSingleton.GetInstance();
            _singleton.Log<GameStateSingleton>("Singleton", "Initializing game state. ");
        }

        public static GameStateSingleton GetInstance()
        {
            return SingletonHolder._instance;
        }

        public Player GetCurrentPlayer()
        {
            return Players[0];
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public int GetCurrentLevel()
        {
            return Level;
        }

        public void IncreaseLevel()
        {
            Level += 1;
        }
        
        public void AddRenderable(IRenderable renderable) {
           _entities.Add(renderable);
        }

        public void SetInConstructionMode(bool value)
        {
            _singleton.Log<GameStateSingleton>("Observer", "Observer set's Construction mode when build tower button is pressed.");
            InConstructionMode = value;
        }

        public bool GetInConstructionMode()
        {
            return InConstructionMode;
        }

        public Agregator<IRenderable> GetRenderables() {
            return _entities.FromList(_entities.ToList().Where(x => !x.IsDisposed()).ToList());
        }
    }
} 