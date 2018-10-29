using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Interfaces
{
    interface IPlayerObserver
    {
        void UpdateMoney(int money);
        void UpdateHealth(int health);
    }
}
