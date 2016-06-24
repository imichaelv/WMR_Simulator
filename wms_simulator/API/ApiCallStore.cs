using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace wms_simulator.API
{
   
    public class ApiCallStore : ApiCall
    {
        private string APPId = "";
        private string APIKey = "";
        static string _pageRequest = "/api/ProductApi/",
            _placeOrder = "/api/placeOrder/",
            _checkOrder = "/api/checkOrder/",
            _confirmDelivery = "/api/confirmDelivery/";

        private int id;


        public ApiCallStore(int id)
        {
            this.id = id;
            
        }

        public async Task<XmlDocument> pageRequest(int page = 1)
        {
            Controller.ConsoleMessage.warning(_server+_pageRequest+page);
            XmlDocument xml =await base.get(_server+_pageRequest+page);
            //Controller.ConsoleMessage.BlueMessage("xml1" + xml);
            return xml;
        }


        public async Task<XmlDocument> placeOrder(Array orderList)
        {
            Controller.ConsoleMessage.warning(_server + _placeOrder);
            Request request = new Request()
            {
                Id = "" + id,
                list = orderList
            };

            return await base.post(_server+_placeOrder,request);
        }

        public async Task<XmlDocument> checkOrder(string oid)
        {
            Request request = new Request()
            {
                Id = "" + id,
                OId = oid
            };
            return await base.post(_server+_checkOrder, request);
        }

        public async Task<XmlDocument> confirmDelivery(string oid)
        {
            Request request = new Request()
            {
                Id = "" + id,
                OId = oid
            };
            return await base.post(_server+_confirmDelivery, request);
        }
    
    }
}
