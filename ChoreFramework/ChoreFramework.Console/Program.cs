using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Classes.Base;

namespace ChoreFramework.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var chores = new List<ChoreBase>();

            foreach (var chore in chores)
            {

            }

            var choreTest01 = new ChoreTest01.ChoreTest01();
            choreTest01.Run(null);
        }
    }
}
