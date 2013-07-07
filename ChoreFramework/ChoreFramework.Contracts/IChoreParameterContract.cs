using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.AddIn.Contract;

namespace ChoreFramework.Contracts
{
    public interface IChoreParameterContract : IContract
    {
        string Name { get; set; }
    }
}
