using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsState
{
    public class AttackState : State
    {
        public override string Execute(Enemy enemy)
        {
            enemy.SetState(new IdleState());
            return "Attacking";
        }
    }
}
