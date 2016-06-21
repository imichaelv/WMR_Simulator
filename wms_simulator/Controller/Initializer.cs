using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wms_simulator;
using wms_simulator.View;

namespace wms_simulator.Controller
{
    public class Initializer
    {
        private string wmsSimulatorPath { get; set; }
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        /// <summary>
        /// 
        /// </summary>
        public Initializer()
        {
            wmsSimulatorPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"WMS_Simulator");
            if (!Directory.Exists(wmsSimulatorPath))
            {
                Console.WriteLine("Initializing new Directory");
                InitializeNew();
                
            }
            else
            {
                Console.WriteLine(wmsSimulatorPath + " Exists");
            }
            
        }

        internal void saveSettings(MainView mainView)
        {
            Properties.Settings.Default.SuppliersBox = mainView.suppliers;
            Properties.Settings.Default.SupplierAmount = mainView.supplierAmmount;
            Properties.Settings.Default.SupplierProcessSpeed = mainView.supplierProcessSpeed;
            Properties.Settings.Default.StoresBox = mainView.stores;
            Properties.Settings.Default.StoresAmount = mainView.storeAmount;
            Properties.Settings.Default.StoresProcessSpeed = mainView.storeProcessSpeed;
            Properties.Settings.Default.SimulatingSpeed = mainView.simulationSpeed;
        }

        private void InitializeNew()
        {
            Directory.CreateDirectory(wmsSimulatorPath);
            Console.WriteLine(System.DateTime.Now + " Creating new %Appdata%/" + wmsSimulatorPath);
        }


       

        public void setStatusLabel(System.Windows.Forms.ToolStripStatusLabel statusLabel)
        {
            this.statusLabel = statusLabel;
        }

        public void PrintConsole(string message)
        {
            if (statusLabel == null)
            {
                PrintConsole(message, null);
            }
            else
            {
                statusLabel.Text = message;
            }
            
        }
        public void PrintConsole(string message, string type)
        {
            if (type == null)
            {
                Console.WriteLine(System.DateTime.Now + " " + message);
            }
            else
            {
                Console.WriteLine(System.DateTime.Now + type + " " + "" + message);
            }
        }

        public static void Print(string message)
        {
            Console.WriteLine(System.DateTime.Now + " " + message);
        }

    }
}
