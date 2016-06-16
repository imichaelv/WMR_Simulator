using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using wms_simulator.Model;
using wms_simulator.Controller;
using wms_simulator.View;


namespace wms_simulator
{
    class Simulator
    {
      
        static void Main()
        {
            Console.Title = "WMS Console PreRun";
            Console.WriteLine(System.DateTime.Now + " Starting up WMS simulator");
            Console.WriteLine(System.DateTime.Now + " Created by Michaël van der Veen");
            Console.WriteLine(System.DateTime.Now + " Checking for first time use.");
            
            Initializer init = new Initializer();
            
            //Console.ReadKey();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainView(new MainController(init)));
            

        }
       
        
    }
}
