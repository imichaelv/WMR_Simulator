using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wms_simulator.API;

namespace wms_simulator.Model
{
    public class Simulator //: SimulatorInterface
    {
        internal string name;
        internal int processSpeed, simulationSpeed, delay, id;
        internal object apiCall;
        internal Dictionary<int,int> rememberedItems;
        internal List<string> oid;
        internal Random random;
        public Simulator(string name, int processSpeed, int simulationSpeed, int id)
        {
            random = new Random();
            this.name = name;
            this.id = id;
            this.processSpeed = processSpeed;
            this.simulationSpeed = simulationSpeed;
            calculatingDelay();
            this.oid = new List<string>();
        }
        internal void calculatingDelay()
        {
            delay = int.Parse("" + (calculatingTime(processSpeed) / calculatingTime(simulationSpeed) * 1000.0));
        }

        internal float calculatingTime(int value)
        {

            switch (value)
            {
                case 0:
                    return 1000; // Realtime      
                case 1:
                    return 30000; // 30 minuten
                case 2:
                    return 45000; // 45 minuten
                case 3:
                    return 90000; // 90 minuten
                case 4:
                    return 180000; // 3 uur
                case 5:
                    return 360000; // 6 uur
                case 6:
                    return 720000; // 12 uur
                case 7:
                    return 144000; // 24 uur
                case 8:
                    return 288000; // 2 dagen
                case 9:
                    return 504000; // 3,5 dagen
                case 10:
                    return 1008000; // 1week RealTime tijd
            }
            return 1000;

        }

        

        void ThreadStart()
        {
            throw new NotImplementedException();
        }
    }
}
