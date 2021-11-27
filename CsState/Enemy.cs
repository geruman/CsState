using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsState
{
    public class Enemy
    {
        private State current;
        public Enemy()
        {
            current = new IdleState();
        }
        public void SetState(State newState)
        {
            current = newState;
        }
        public string Execute()
        {
            return current.Execute(this);
        }
    }
}
