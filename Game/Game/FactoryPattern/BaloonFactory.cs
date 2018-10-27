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
        public BaloonFactory()
        {
            baloons = new List<Baloon>();
            APIHelper = new APIBaloonsHelper();
        }
        public async void CreateBaloon(string BaloonType)
        {

            switch(BaloonType)
            {
                case "WeakBaloon":
                    //await APIHelper.GetBaloonById("1");
                    baloons.Add(new WeakBaloon());
                    break;
                case "IntermediateBaloon":
                    baloons.Add(new IntermediateBaloon());
                    break;
                case "PowerfulBaloon":
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
