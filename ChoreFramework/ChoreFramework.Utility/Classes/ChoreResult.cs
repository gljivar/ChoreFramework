using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChoreFramework.Utility.Classes
{
    public sealed class ChoreResult
    {
        public bool Successful { get; set; }
        public object ReturnValue { get; set; }
    }
}
