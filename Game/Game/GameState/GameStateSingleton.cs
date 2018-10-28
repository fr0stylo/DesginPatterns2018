using Game.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Game.Entities
{
    public class GameStateSingleton
    {
        private int Id;
        private List<Player> Players;
        private List<IBaloon> Player1Baloons;
        private List<IBaloon> Player2Baloons;
        private bool AllowAddPlayer1Baloons;
        private bool AllowAddPlayer2Baloons;
        private int Level;

        private static class SingletonHolder
        {
            public static readonly GameStateSingleton _instance = new GameStateSingleton();
        }

        private GameStateSingleton()
        {
            Players = new List<Player>();
            Player1Baloons = new List<IBaloon>();
            Player2Baloons = new List<IBaloon>();
            AllowAddPlayer1Baloons = true;
            AllowAddPlayer2Baloons = true;
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
        public void AddPlayer1Baloon(IBaloon baloon)
        {
            if(AllowAddPlayer1Baloons)
                Player1Baloons.Add(baloon);
        }
        public void AddPlayer2Baloon(IBaloon baloon)
        {
            if(AllowAddPlayer2Baloons)
                Player2Baloons.Add(baloon);
        }
        public void AddPlayer1BaloonList(List<IBaloon> baloons)
        {
            Player1Baloons.AddRange(baloons);
        }
        public void AddPlayer2BaloonList(List<IBaloon> baloons)
        {
            Player2Baloons.AddRange(baloons);
        }
        public List<IBaloon> GetPlayer1Baloons()
        {
            return Player1Baloons;
        }
        public List<IBaloon> GetPlayer2Baloons()
        {
            return Player2Baloons;
        }
        public void SetAllowAddPlayer1Baloons(bool value)
        {
            AllowAddPlayer1Baloons = value;
        }
        public bool GetAllowAddPlayer1Baloons()
        {
            return AllowAddPlayer1Baloons;
        }
        public void SetAllowAddPlayer2Baloons(bool value)
        {
            AllowAddPlayer2Baloons = value;
        }
        public bool GetAllowAddPlayer2Baloons()
        {
            return AllowAddPlayer2Baloons;
        }
    }
}