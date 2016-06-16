using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms_simulator.Controller
{
    public class MainController
    {
        private Initializer initializer;

        public MainController(Initializer initializer)
        {
            this.initializer = initializer;
        }

        public void setLabel(System.Windows.Forms.ToolStripStatusLabel statusLabel)
        {
            initializer.setStatusLabel(statusLabel);
        }

        public void startSimulating()
        {

        }

        public void sendMessage(string message)
        {
            initializer.PrintConsole(message);
        }
    }
}
