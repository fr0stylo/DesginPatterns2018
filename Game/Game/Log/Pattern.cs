using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Log
{
    class Pattern : IExpression
    {
        public string _pattern { get; set; }

        public void Execute(Context context)
        {
            context.addText(_pattern + ": ");
        }
    }
}
