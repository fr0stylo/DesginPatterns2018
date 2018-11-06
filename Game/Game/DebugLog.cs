using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class DebugLog
    {
        public string Class { get; set; }
        public string Execution { get; set; }

        public override string ToString() {
            return $"{Class}: {Execution} \n";
        }
    }
}
