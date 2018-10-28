using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;

namespace Game.BuilderPattern
{
    public class Wave {
        public int Number;
        public int Spacing;
        public IList<IBaloon> Baloons;
    }
}
