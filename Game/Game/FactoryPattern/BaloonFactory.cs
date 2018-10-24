using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.FactoryPattern
{
    class BaloonFactory
    {
        private List<IBaloon> baloons;
        private static BaloonFactory _instance;
        public BaloonFactory()
        {
            baloons = new List<IBaloon>();
        }
        public void CreateBaloon(string BaloonType)
        {
            switch(BaloonType)
            {
                case "WeakBaloon":
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
        public List<IBaloon> Baloons()
        {
            return baloons;
        }
    }
}
