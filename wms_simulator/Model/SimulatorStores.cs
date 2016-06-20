using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace wms_simulator.Model
{
    public class SimulatorStores
    {
        private Dictionary<string, Thread> storesList = new Dictionary<string, Thread>();
        private StoreNames storeNames;
        
        /// <summary>
        /// 
        /// </summary>
        public SimulatorStores()
        {
            storeNames = new StoreNames();
        }

        /// <summary>
        /// Adding stores 
        /// </summary>
        /// <param name="processSpeed"></param>
        /// <param name="simulationSpeed"></param>
        public void addStores(int processSpeed, int simulationSpeed)
        {
            string name = storeNames.getNewStore();
            Store store = new Store(name,processSpeed,simulationSpeed);
            Thread newTread = new Thread(new ThreadStart(store.ThreadStart));
            newTread.Start();
            storesList.Add(name, newTread);
        }
        
        /// <summary>
        /// Adding stores
        /// </summary>
        /// <param name="mainView"></param>
        public void addStores(wms_simulator.View.MainView mainView)
        {
            int amount = mainView.storeAmount;
            int processSpeed = mainView.storeProcessSpeed;
            int simulatingSpeed = mainView.simulationSpeed;

            for(int i =0; i < amount; i++)
            {
                addStores(processSpeed,simulatingSpeed);
            }
        }

        public void reset()
        {
            Console.WriteLine(System.DateTime.Now + " Resetting Simulator");
            foreach(KeyValuePair<string,Thread> store in storesList)
            {
                store.Value.Abort();
            }
            storeNames = new StoreNames();
            storesList = new Dictionary<string, Thread>();
        }

    }
}
