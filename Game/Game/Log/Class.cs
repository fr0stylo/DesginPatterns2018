using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Log
{
    class Class : IExpression
    {
        public string _class { get; set; }

        public void Execute(Context context)
        {
            context.addText(_class + " - ");
        }
    }
}
