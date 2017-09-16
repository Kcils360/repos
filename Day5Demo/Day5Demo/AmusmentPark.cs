using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Demo
{
    abstract class AmusmentPark : Park
    {
        public string Food { get; set; }

        public bool AcceptsPets()
        {
            return true;
        }

        public sealed override int CollectFees()
        {
            return base.CollectFees() + 30;
        }
    }
}
