using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.CompositePattern;

namespace Game.Entities.Baloons
{
    public abstract class MasterBaloon : Component
    {
        public abstract void Sprint();
    }
}
