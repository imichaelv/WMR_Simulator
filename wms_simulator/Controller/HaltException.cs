using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms_simulator.Controller
{
    class HaltException : Exception
    {
        private AggregateException e;

        public HaltException(AggregateException e)
        {
            this.e = e;
        }

        public HaltException(string e) :base(e) { }
    }
}
