using Game.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Game.Entities
{
    public class GameStateSingleton
    {
        private int Id;
        private List<Player> Players;
        private List<Point> TowerPositions;
        private List<Baloon> Baloons;
        private int Level;
        
        private static class SingletonHolder
        {
            public static readonly GameStateSingleton _instance = new GameStateSingleton();
        }
        
        private GameStateSingleton()
        {
            Players = new List<Player>();
            TowerPositions = new List<Point>();
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
    }
}