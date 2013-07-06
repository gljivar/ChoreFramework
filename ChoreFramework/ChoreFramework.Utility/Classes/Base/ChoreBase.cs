using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChoreFramework.Utility.Interfaces;

namespace ChoreFramework.Utility.Classes.Base
{
    public abstract class ChoreBase : IChore
    {
        public List<IChoreParameter> ChoreParameters { get; set; }

        public ChoreBase()
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

        protected abstract void AddChoreParameters();

    }
}
