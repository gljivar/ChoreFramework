using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChoreFramework.Utility.Classes.Base
{
    public abstract class ChoreHostView
    {
        public abstract ChoreResult Run(ChoreParameters parameters);
    }
}
