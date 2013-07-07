using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChoreFramework.AddInViews
{
    public class ChoreParameters
    {
        public List<IChoreParameter> OriginalParameters { get; set; }
        public List<IChoreParameter> PreviousParameters { get; set; }
        public List<List<IChoreParameter>> AllParameters { get; set; }
        //TODO: Perhaps add more
    }
}
