using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Log
{
    class Context
    {
        private string _usedPattern { get; set; }
        public string _pattern { get; set; }

        public void addText(string data)
        {
            _usedPattern = _usedPattern + data;
        }

        public override string ToString()
        {
            return $"{_usedPattern} \n";
        }
    }
}
