using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace wms_simulator.Model
{
    class StoreNames
    {
        private string[] stores = new string[] { "Bart Smid", "Intertoys", "Speelboom", "Speel-O-Theek", "Speelgoed land", "Steengoed", "Top1Toys","Toy\"R\"Us", "Wehkamp", "Bol.com" };
        private string[] locations = new string[] {"Groningen", "Assen","Leeuwarden","Zwolle","Utrecht","Enchedee","Almere","Amsterdam","Den Haag","Rotterdam","Zaandam","Emmen","Eindhoven","Tilburg","Goes","Breda","Nijmegen","Apeldoorn"};
        private int[,] usedCombinations;
        private int maxStores;
        private int count = 0;

        public StoreNames()
        {
            usedCombinations = new int[stores.Length,locations.Length];
            maxStores = stores.Length * locations.Length;
        }
        /// <summary>
        /// gets a new Store
        /// </summary>
        /// <returns></returns>
        public string getNewStore()
        {
            if (count != maxStores)
            {
                return newStore(null);
            }

            else {
                Console.WriteLine("NoMoreStores to Generate");
                return "noMoreStores";
            }
        }

        /// <summary>
        /// Returns a new Store, checks if the store isnt mensioned bevore returns the string, else checks again till no more stores are left.
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        private string newStore(string lastName)
        {
            if (lastName == null)
            {
                Random random = new Random();
                int storeId = random.Next(0, stores.Length);

                int locationId = random.Next(0, locations.Length);

                if (usedCombinations[storeId, locationId] != 0)
                {
                    usedCombinations[storeId, locationId] = 1;
                    return stores[storeId] + " " + locations[locationId];
                }
            }

            return newStore(lastName);
        }

        private void loadStores()
        {
            for(int i = 0; i < (stores.Length * locations.Length); i++)
            {
                //TODO load all in array and update new Store
            }
        }
    }
}
