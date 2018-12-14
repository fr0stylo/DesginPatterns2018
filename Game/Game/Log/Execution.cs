﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Log
{
    class Execution : IExpression
    {
        public string _execution { get; set; }

        public void Execute(Context context)
        {
            context.addText(_execution);
        }
    }
}
