﻿using System;
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
            SimulatorSpeedDisplay.Text = ""+ (this.simulationSpeed = speedbar.Value);
            
        }

        private void AmountSuppliersBar_Scroll(object sender, EventArgs e)
        {
            SupplierAmountDisplay.Text =""+( this.supplierAmmount = AmountSuppliersBar.Value);
        }

        private void SupplierProcessSpeedBar_Scroll(object sender, EventArgs e)
        {
            SupplierProcessSpeedDisplay.Text =""+(this.supplierProcessSpeed = SupplierProcessSpeedBar.Value);
        }

        private void AmountStoresBar_Scroll(object sender, EventArgs e)
        {
            StoresAmmountDisplay.Text = ""+ (this.storeAmount = (AmountStoresBar.Value*10));
        }

        private void StoresProcessSpeedBar_Scroll(object sender, EventArgs e)
        {
            StoresProcessSpeedDisplay.Text= ""+( this.storeProcessSpeed = StoresProcessSpeedBar.Value);
        }

        private void StoresBox_CheckedChanged(object sender, EventArgs e)
        {
            this.stores = StoresBox.Checked;
        }
    }
}
