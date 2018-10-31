using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Command
{
    public interface ICommand
    {
        dynamic Execute();
    }
}
