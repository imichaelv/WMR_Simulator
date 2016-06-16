using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace wms_simulator.Model
{
    class Store 
    {
        private string name;


        public Store(string name)
        {
            this.name = name;
        }
       
        public void ThreadStart()
        {
            while (true)
            {
                Console.WriteLine("Test");
            }
        }

    }
}
