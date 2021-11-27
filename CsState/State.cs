using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsState
{
    public abstract class State
    {
        public abstract string Execute(Enemy enemy);
    }
}
