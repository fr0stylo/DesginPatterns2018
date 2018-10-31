using Game.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Game.Entities.Buildings;
using Game.GameState;

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
        private List<IRenderable> _entities;

        private static class SingletonHolder
        {
            public static readonly GameStateSingleton _instance = new GameStateSingleton();
        }

        private GameStateSingleton()
        {
            Players = new List<Player>();
            _entities = new List<IRenderable>();
            AllowAddPlayer1Baloons = true;
            AllowAddPlayer2Baloons = true;
            InConstructionMode = false;
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
            InConstructionMode = value;
        }

        public bool GetInConstructionMode()
        {
            return InConstructionMode;
        }

        public List<IRenderable> GetRenderables() {
            return _entities.Where(x => !x.IsDisposed()).ToList();
        }
    }
}