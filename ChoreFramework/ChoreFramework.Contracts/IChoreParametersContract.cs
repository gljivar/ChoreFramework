using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.AddIn.Contract;

namespace ChoreFramework.Contracts
{
    public interface IChoreParametersContract : IContract
    {
        List<IChoreParameterContract> OriginalParameters { get; set; }
        List<IChoreParameterContract> PreviousParameters { get; set; }
        List<List<IChoreParameterContract>> AllParameters { get; set; }
    }
}
