using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Log
{
    interface IExpression
    {
        void Execute(Context context);
    }
}
