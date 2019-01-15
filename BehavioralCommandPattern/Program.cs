using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create user and let her compute

            Invoker invoker = new Invoker();

            // User presses calculator buttons

            invoker.Compute('+', 100);
            invoker.Compute('-', 50);
            invoker.Compute('*', 10);
            invoker.Compute('/', 2);

            // Undo 4 commands

            invoker.Undo(4);

            // Redo 3 commands

            invoker.Redo(3);

            // Wait for user

            Console.ReadKey();
        }
    }
}
