using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.AddIn.Pipeline;

namespace ChoreFramework.AddInViews
{
    [AddInBase]
    public abstract class Chore
    {
        public List<IChoreParameter> ChoreParameters { get; set; }

        public Chore()
        {
            SetChoreParameters();
        }

        public virtual ChoreResult Run(ChoreParameters parameters)
        {
            throw new NotImplementedException();
        }

        private void SetChoreParameters()
        {
            this.ChoreParameters = new List<IChoreParameter>();

            AddChoreParameters();
        }

        protected virtual void AddChoreParameters()
        {

        }
    }
}
