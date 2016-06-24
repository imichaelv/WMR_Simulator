using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wms_simulator.Controller;

namespace wms_simulator.View
{
    public partial class MainView : Form
    {
        public int simulationSpeed { get; set; }
        public int supplierAmmount { get; set; }
        public int supplierProcessSpeed { get; set; }
        public int storeAmount { get; set; }
        public int storeProcessSpeed { get; set; }
        public bool suppliers { get; set; }
        public bool stores { get; set; }
        private MainController mainController;
        public MainView(MainController mainController)
        {
            this.mainController = mainController;
            mainController.setLabel(this.StatusLabel);
            InitializeComponent();
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            mainController.startSimulating(this);
            mainController.sendMessage("Running simulator");
            StartButton.BackColor = Color.Violet;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.suppliers = SuppliersBox.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void speedbar_Scroll(object sender, EventArgs e)
        {
            SimulatorSpeedDisplay.Text = simulatingSpeedText(this.simulationSpeed = speedbar.Value);
            
        }

        private void AmountSuppliersBar_Scroll(object sender, EventArgs e)
        {
            SupplierAmountDisplay.Text =simulatingDeliverySpeed( this.supplierAmmount = AmountSuppliersBar.Value);
        }

        private void SupplierProcessSpeedBar_Scroll(object sender, EventArgs e)
        {
            SupplierProcessSpeedDisplay.Text =simulatingTime(this.supplierProcessSpeed = SupplierProcessSpeedBar.Value);
        }

        private void AmountStoresBar_Scroll(object sender, EventArgs e)
        {
            //TODO undo outcomment
            StoresAmmountDisplay.Text = "" + (this.storeAmount = (AmountStoresBar.Value*10)); 
        }

        private void StoresProcessSpeedBar_Scroll(object sender, EventArgs e)
        {
            StoresProcessSpeedDisplay.Text= simulatingTime( this.storeProcessSpeed = StoresProcessSpeedBar.Value);
        }

        private void StoresBox_CheckedChanged(object sender, EventArgs e)
        {
            this.stores = StoresBox.Checked;
        }

        private string simulatingTime(int value)
        {
            switch (value)
            {
                case 0:
                    return "Direct";
                case 1:
                    return "30 minutes";
                case 2:
                    return "45 minutes";
                case 3:
                    return "90 minutes";
                case 4:
                    return "3 hours";
                case 5:
                    return "6 hours";
                case 6:
                    return "12 hours";
                case 7:
                    return "24 hours";
                case 8:
                    return "2 days";
                case 9:
                    return "3,5 days";
                case 10:
                    return "1 week";
            }
            return null;
        }

        private string simulatingSpeedText(int val)
        {
            switch (val)
            {
                case 0:
                    return "RealTime";
                case 1:
                    return "+30 minutes";
                case 2:
                    return "+45 minutes";
                case 3:
                    return "+90 minutes";
                case 4:
                    return "+3 hours";
                case 5:
                    return "+6 hours";
                case 6:
                    return "+12 hours";
                case 7:
                    return "+24 hours";
                case 8:
                    return "+2 days";
                case 9:
                    return "+3,5 days";
                case 10:
                    return "+1 week";
            }
            return null;
        }

        private string simulatingDeliverySpeed(int val)
        {
            switch (val)
            {
                case 0:
                    return "Teleportation";
                case 1:
                    return "Fiber Cable Upload";
                case 2:
                    return "ThrustSSC Rocketcar";
                case 3:
                    return "Flight Falcon 16";
                case 4:
                    return "TGV Duplex Heigh Speed Train";
                case 5:
                    return "Dubbeldekker Intercity";
                case 6:
                    return "Taxi";
                case 7:
                    return "Courier";
                case 8:
                    return "Trucking";
                case 9:
                    return "Cargo Bike";
                case 10:
                    return "On Foot";
            }
            return null;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainController.reset(this);
        }
    }
}
