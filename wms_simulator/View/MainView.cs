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
        private MainController mainController;
        public MainView(MainController mainController)
        {
            this.mainController = mainController;
            mainController.setLabel(this.StatusLabel);
            InitializeComponent();
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            mainController.startSimulating();
            mainController.sendMessage("Running simulator");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void speedbar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
