using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Log
{
    class DebugLog
    {
        public Context context;

        public DebugLog(string _pattern, string _class, string _ex)
        {
            context = new Context{_pattern = _pattern};

            IExpression exp1 = new Pattern { _pattern = _pattern };
            IExpression exp2 = new Class { _class = _class };
            IExpression exp3 = new Execution { _execution = _ex };

            exp1.Execute(context);
            exp2.Execute(context);
            exp3.Execute(context);
        }

        public override string ToString() {
            return $"{context} \n";
        }
    }
}
