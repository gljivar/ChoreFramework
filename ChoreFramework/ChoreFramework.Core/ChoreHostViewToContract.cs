using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.AddIn.Pipeline;
using ChoreFramework.Utility.Classes.Base;
using ChoreFramework.Utility.Interfaces;
using ChoreFramework.Utility.Classes;

namespace ChoreFramework.Core
{
    [HostAdapter]
    public class TranslatorHostViewToContract : ChoreHostView
    {
        IChore _contract;
        ContractHandle _lifetime;

        public TranslatorHostViewToContract(IChore contract)
        {
            _contract = contract;
            _lifetime = new ContractHandle(contract);
        }

        public override ChoreResult Run(ChoreParameters parameters)
        {
            return _contract.Run(parameters);
        }
    }
}
