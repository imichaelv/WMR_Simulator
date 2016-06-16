using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wms_simulator.Model;

namespace wms_simulator.Controller
{
    public class MainController
    {
        private Initializer initializer;
        private SimulatorStores simulatorStores;

        public MainController(Initializer initializer)
        {
            simulatorStores = new SimulatorStores();
            this.initializer = initializer;
        }

        public void setLabel(ToolStripStatusLabel statusLabel)
        {
            initializer.setStatusLabel(statusLabel);
        }

        public void startSimulating(View.MainView mainView)
        {
            simulatorStores.addStores(mainView.storeAmount);
        }

        public void sendMessage(string message)
        {
            initializer.PrintConsole(message);
        }
    }
}
