using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChoreFramework.AddInViews
{
    public sealed class ChoreParameter<T> : IChoreParameter
    {
        public string Name { get; set; }
        public T DefaultValue { get; set; }
        public T Value { get; set; }
    }
}
