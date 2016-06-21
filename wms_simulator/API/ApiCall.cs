using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace wms_simulator.API
{
    class Request
    {
        public string Instance { get; set; }
        public string Type { get; set; }
        public int Page { get; set; }
        public int itemPageLimit { get; set; }
    }
    class ApiCall : ApiCallInterface
    {
        private HttpClient client;
        void ApiCallInterface.runRequest()
        {
            using (client = new HttpClient())
            {

                client.BaseAddress = new Uri(Properties.Settings.Default.ServerAddress+":"+Properties.Settings.Default.ServerPort+"//");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            }
            
        }
        HttpResponseMessage ApiCallInterface.getPage()
        {
            throw new NotImplementedException();
        }

        HttpResponseMessage ApiCallInterface.post()
        {
            throw new NotImplementedException();
        }

        void ApiCallInterface.StartApi()
        {
            throw new NotImplementedException();
        }

        
    }
}
