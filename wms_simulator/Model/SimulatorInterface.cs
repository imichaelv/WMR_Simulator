﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms_simulator.Model
{
    public interface SimulatorInterface
    {
        //void Store(string name, int processSpeed, int simulationSpeed, int id);

        void calculatingDelay();

        void ThreadStart();

        float calculatingTime(int value);
       
    }
}
