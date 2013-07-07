using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Classes;
using System.AddIn;

namespace ChoreTest01
{
    [AddIn("ChoreTest01", Description="Chore test 01", Version="1.0.0.0", Publisher="MV")]
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
            this.ChoreParameters.Add(new ChoreParameter<bool>() { Name = "bul", DefaultValue = true, Value = true });
            this.ChoreParameters.Add(new ChoreParameter<string>() { Name = "databs", DefaultValue = "Database", Value = "Data base" });
            this.ChoreParameters.Add(new ChoreParameter<int>() { Name = "Numbr", DefaultValue = 0, Value = 1 });
        }
    }
}
