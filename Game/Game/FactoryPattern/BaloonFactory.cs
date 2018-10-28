using Game.Entities;
using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Helpers.Enums;

namespace Game.FactoryPattern
{
    class BaloonFactory
    {
        private List<IBaloon> baloons;
        private static BaloonFactory _instance;
        APIBaloonsHelper APIHelper;
        private bool isPlayer1Factory;
        
        public BaloonFactory(bool isPlayer1Factory)
        {
            this.isPlayer1Factory = isPlayer1Factory;
            baloons = new List<IBaloon>();
            APIHelper = new APIBaloonsHelper();
        }
        
        public async void CreateBaloon(BaloonTypes baloonType)
        {
            switch(baloonType)
            {
                case BaloonTypes.Weak:
                    //await APIHelper.GetBaloonById("1");
                    baloons.Add(new WeakBaloon(isPlayer1Factory));
                    break;
                case BaloonTypes.Intermediate:
                    baloons.Add(new IntermediateBaloon(isPlayer1Factory));
                    break;
                case BaloonTypes.Powerful:
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
        
        public List<IBaloon> Baloons()
        {
            return baloons;
        }
    }
}
