using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Classes.Base;
using ChoreFramework.Utility.Classes;

namespace ChoreFramework.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var chores = new List<ChoreBase>();
            var choreTest01 = new ChoreTest01.ChoreTest01();
            chores.Add(choreTest01);

            foreach (var chore in chores)
            {
                foreach (var cParam in chore.ChoreParameters)
                {
                    StringBuilder sb = new StringBuilder();

                    if (cParam is ChoreParameter<bool>)
                    {
                        var cParamRes = cParam as ChoreParameter<bool>;
                        sb.AppendLine("Param " + cParam.Name + " Value " + cParamRes.Value);
                    }
                    else if (cParam is ChoreParameter<string>)
                    {
                        var cParamRes = cParam as ChoreParameter<string>;
                        sb.AppendLine("Param " + cParam.Name + " Value " + cParamRes.Value);
                    }
                    else if (cParam is ChoreParameter<int>)
                    {
                        var cParamRes = cParam as ChoreParameter<int>;
                        sb.AppendLine("Param " + cParam.Name + " Value " + cParamRes.Value);
                    }

                    System.Console.WriteLine(sb.ToString());
                }
            }

            
            choreTest01.Run(null);
        }
    }
}
