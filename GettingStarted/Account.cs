using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingStarted
{
    public class Account
    {
        public int DivisionID { get; set; }
        public int BranchID { get; set; }
        public int CostCentreID { get; set; }

        public void BeginEdit() { }

        public void EndEdit() { }

        public void EnableValidation() { }
    }
}
