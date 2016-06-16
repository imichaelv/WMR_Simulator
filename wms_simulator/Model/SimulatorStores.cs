using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace wms_simulator.Model
{
    class SimulatorStores
    {
        private Dictionary<string, Thread> storesList = new Dictionary<string, Thread>();
        private StoreNames storeNames;

        public SimulatorStores()
        {
            storeNames = new StoreNames();
        }

        public void addStores()
        {
            string name = storeNames.getNewStore();
            Store store = new Store(name);
            Thread newTread = new Thread(new ThreadStart(store.ThreadStart));
            storesList.Add(name, newTread);
        }
        

    }
}
