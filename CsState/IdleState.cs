using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsState
{
    public class IdleState : State
    {
        private Random r;
        public IdleState()
        {
            System.Threading.Thread.Sleep(1000);
            r = new Random();
        }
        public override string Execute(Enemy enemy)
        {
            
            if (r.Next(100)>49)
            {
                enemy.SetState(new AttackState());

            }
            else{
                enemy.SetState(new DefendState());
            }
            return "Idle, thinking...";
        }
    }
}
