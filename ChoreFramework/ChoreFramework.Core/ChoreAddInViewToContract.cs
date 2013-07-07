using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.AddIn.Pipeline;
using ChoreFramework.Utility.Interfaces;
using ChoreFramework.Utility.Classes.Base;
using ChoreFramework.Utility.Classes;

namespace ChoreFramework.Core
{
    [AddInAdapter]
    public class TranslatorAddInViewToContract : ChoreBase, IChore
    {
        ChoreBase _view;

        public TranslatorAddInViewToContract(ChoreBase view)
        {
            _view = view;
        }

        public override ChoreResult Run(ChoreParameters parameters)
        {
            return _view.Run(parameters);
        }
    }
}
