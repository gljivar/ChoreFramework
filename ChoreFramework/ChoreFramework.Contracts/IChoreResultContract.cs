using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.AddIn.Contract;

namespace ChoreFramework.Contracts
{
    interface IChoreResultContract : IContract
    {
        bool Successful { get; set; }
        object ReturnValue { get; set; }
    }
}
