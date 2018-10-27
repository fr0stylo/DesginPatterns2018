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
        private List<Baloon> baloons;
        private static BaloonFactory _instance;
        APIBaloonsHelper APIHelper;
        
        public BaloonFactory()
        {
            baloons = new List<Baloon>();
            APIHelper = new APIBaloonsHelper();
        }
        
        public async void CreateBaloon(BaloonTypes baloonType)
        {
            switch(baloonType)
            {
                case BaloonTypes.Weak:
                    //await APIHelper.GetBaloonById("1");
                    baloons.Add(new WeakBaloon());
                    break;
                case BaloonTypes.Intermediate:
                    baloons.Add(new IntermediateBaloon());
                    break;
                case BaloonTypes.Powerful:
                    baloons.Add(new PowerfulBaloon());
                    break;
                default:
                    break;
                    
            }
        }

        public static BaloonFactory GetInstance()
        {
            return _instance ?? (_instance = new BaloonFactory());
        }
        
        public List<Baloon> Baloons()
        {
            return baloons;
        }
    }
}
