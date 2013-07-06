using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Interfaces;

namespace ChoreFramework.Utility.Classes
{
    public sealed class ChoreParameter<T> : IChoreParameter
    {
        public T DefaultValue { get; set; }
        public T Value { get; set; }
    }
}
