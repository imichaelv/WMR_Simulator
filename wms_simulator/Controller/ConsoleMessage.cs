using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms_simulator.Controller
{
    public static class ConsoleMessage
    {


        public static void WhiteMessage(string message)
        {
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public static void RedMessage(String message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void YellowMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void BlueMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void warning(string message)
        {
            YellowMessage(message);
        }
        public static void error(string message)
        {
            RedMessage(message);
        }

        public static void info(string message)
        {
            BlueMessage(message);
        }
    }
}
