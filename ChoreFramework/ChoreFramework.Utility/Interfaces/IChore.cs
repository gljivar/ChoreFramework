using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Classes;
using System.AddIn.Pipeline;
using System.AddIn.Contract;

namespace ChoreFramework.Utility.Interfaces
{
    [AddInContract]
    public interface IChore : IContract
    {
        ChoreResult Run(ChoreParameters parameters);
    }
}
