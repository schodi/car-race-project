using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    public class FakeDice : IDice
    {
        #region properties
        public int Dots { get; set; }
        public bool RollWasCalled { get; private set; } = false;
        #endregion properties

        #region methods
        public void Roll()
        {
            RollWasCalled = true;
        }
        #endregion methods

    }
}
