using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using wms_simulator.API;
using wms_simulator.Controller;


namespace wms_simulator.Model
{
    class Store : Simulator
    {
        private ApiCallStore apiCallStore;
       

        public Store(string name, int processSpeed, int simulationSpeed, int id) : 
            base(name, processSpeed, simulationSpeed, id)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        public void ThreadStart()
        {
            try {
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine(System.DateTime.Now+" "+name);
                Random rand = new Random();
                //Random start delay
                Thread.Sleep(rand.Next(0, delay));
                apiCallStore = new ApiCallStore(id);
                while (true)
                {
                    stopwatch.Reset();
                    stopwatch.Start();

                    rememberedItems = new Dictionary<int, int>();

                    viewPages();
                    orderItems();
                    checkDelivery();

                    stopwatch.Stop();
                    try { Thread.Sleep(delay - int.Parse(stopwatch.ElapsedMilliseconds.ToString())); }
                    catch (ArgumentOutOfRangeException e) { };
                }
            }
            catch(HaltException e)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ResetColor();
            }
        }


        private void viewPages()
        {
            for(int i = 0; i < random.Next(1, 10000); i++)
            {

                XmlDocument xml=null;
                try
                {
                    xml = apiCallStore.pageRequest(i).Result;
                    Controller.ConsoleMessage.BlueMessage("xml:" + xml);
                    readPage(xml);
                }
                catch (System.AggregateException e)
                {
                    Console.WriteLine(e);
                    throw new HaltException(e);
                }
                if (rememberedItems.Count > 1)
                {
                    i = random.Next(i, 10000);
                }
                
            }

        }

        private void readPage(XmlDocument xml)
        {
            try {
                XmlTextWriter writer = new XmlTextWriter(Console.Out);
                writer.Formatting = Formatting.Indented;
                xml.WriteTo(writer);
                writer.Flush();
                Console.WriteLine();
                //Controller.ConsoleMessage.info(xml.ToString());

                XmlElement root = xml.DocumentElement;
                XmlNodeList elemList = root.GetElementsByTagName("/root/ProductId");
                int count = elemList.Count;
                Controller.ConsoleMessage.info("Count" + count);
                for (int i = 0; i < count; i++)
                {
                    if (random.Next(0, 9) == 1)
                    {
                        int maxItems = int.Parse(xml.SelectNodes("/root/").Item(i).SelectNodes("ProductId").Item(0).Value);
                        Controller.ConsoleMessage.RedMessage("items: " + maxItems);
                        int buyAmount = random.Next(1, maxItems);
                        int itemID = int.Parse(xml.SelectNodes("/Amount").Item(i).Value);
                        rememberedItems.Add(itemID, buyAmount);
                    }
                }

            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e);
            }
        }

        private void orderItems()
        {
            Array order = rememberedItems.ToArray();
            try {
                XmlDocument xml = apiCallStore.placeOrder(order).Result;
                oid.Add(xml.GetElementById("oid").InnerText);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void checkDelivery()
        {
            foreach(string orderId in oid)
            {
                XmlDocument xml = apiCallStore.checkOrder(orderId).Result;
                if(xml.GetElementById("status").InnerText == "Offered")
                {
                    confirmDelivery(orderId);
                    oid.Remove(orderId);
                }
            }
           
        }

        private void confirmDelivery(string orderId)
        {
            XmlDocument xml = apiCallStore.confirmDelivery(orderId).Result;
        }
    


    }
}
