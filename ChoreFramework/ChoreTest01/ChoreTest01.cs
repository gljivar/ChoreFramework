using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Classes;

namespace ChoreTest01
{
    public class ChoreTest01 : ChoreFramework.Utility.Classes.Base.ChoreBase
    {
        public override ChoreResult Run(ChoreParameters parameters)
        {
            var result = new ChoreResult();
            result.Successful = true;
            result.ReturnValue = 1;

            return result;
        }

        protected override void AddChoreParameters()
        {
            this.ChoreParameters.Add(new ChoreParameter<bool>() { DefaultValue = true, Value = true });
        }
    }
}
