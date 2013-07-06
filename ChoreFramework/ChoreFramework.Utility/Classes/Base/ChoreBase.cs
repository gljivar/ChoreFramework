using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Interfaces;

namespace ChoreFramework.Utility.Classes.Base
{
    public abstract class ChoreBase : IChore
    {
        public virtual ChoreResult Run(ChoreParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
