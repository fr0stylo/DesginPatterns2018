using Game.Entities;
using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.FactoryPattern
{
    class BaloonFactory
    {
        private List<Baloon> baloons;
        private static BaloonFactory _instance;
        APIBaloonsHelper APIHelper;
        private bool isPlayer1Factory;
        
        public BaloonFactory(bool isPlayer1Factory)
        {
            this.isPlayer1Factory = isPlayer1Factory;
            baloons = new List<Baloon>();
            APIHelper = new APIBaloonsHelper();
        }
        
        public async void CreateBaloon(string BaloonType)
        {
            switch(BaloonType)
            {
                case "WeakBaloon":
                    //await APIHelper.GetBaloonById("1");
                    baloons.Add(new WeakBaloon(isPlayer1Factory));
                    break;
                case "IntermediateBaloon":
                    baloons.Add(new IntermediateBaloon(isPlayer1Factory));
                    break;
                case "PowerfulBaloon":
                    baloons.Add(new PowerfulBaloon(isPlayer1Factory));
                    break;
                default:
                    break;
                    
            }
        }

        public static BaloonFactory GetInstance(bool isPlayer1Factory)
        {
            return _instance ?? (_instance = new BaloonFactory(isPlayer1Factory));
        }
        
        public List<Baloon> Baloons()
        {
            return baloons;
        }
    }
}
