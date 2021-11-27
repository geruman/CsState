using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsState
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.WriteLine(enemy.Execute());
            Console.ReadKey();
        }
    }
}
