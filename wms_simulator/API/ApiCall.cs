
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace wms_simulator.API
{
    /// <summary>
    /// Request object for POST requests
    /// </summary>
    public class Request
    {
        public string Id { get; set; }
        public string OId { get; set; }
        public string Value_one { get; set; }
        public string Value_two { get; set; }
        public Array list { get; set; }
    }


    /// <summary>
    /// API 
    /// </summary>
    public class ApiCall : ApiCallInterface
    {
        private HttpClient client;
        private string APPId;
        private string APIKey;
        private XmlDocument xml;
        internal static string _server = Properties.Settings.Default.ServerAddress + ":" + Properties.Settings.Default.ServerPort;



        public async Task<XmlDocument> post(string apiLocation, Request request)
        {
            await RunAsync(request, apiLocation);

            return xml;
        }



        async Task<XmlDocument> RunAsync(Request request, string apiCall)
        {
            string apiAdress = Properties.Settings.Default.ServerAddress + ":" + Properties.Settings.Default.ServerPort+apiCall;

            CustomDelegatingHandler customeDelegatingHandler = new CustomDelegatingHandler();

            HttpClient client = HttpClientFactory.Create(customeDelegatingHandler);
            HttpResponseMessage response = await client.PutAsXmlAsync(apiAdress, request);

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(responseString);
                return xml;
            }
            return null;

        }


        public async Task<XmlDocument> get(string apiLocation)
        {

            CustomDelegatingHandler customDelegatingHandler = new CustomDelegatingHandler();
            HttpClient client = HttpClientFactory.Create(customDelegatingHandler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
            HttpResponseMessage response = await client.GetAsync(apiLocation); 
            if (response.IsSuccessStatusCode)
            {
                string xmlD = response.Content.ReadAsStringAsync().Result;
                Controller.ConsoleMessage.BlueMessage(xmlD);

                XmlDocument xml = JsonConvert.DeserializeXmlNode("{\"root\":" +xmlD + "}", "root");

                return xml;
                //XmlDocument xmlDoc = await response.Content.ReadAsAsync<XmlDocument>();
                //return  JsonConvert.DeserializeXmlNode(xmlDoc);
                /*xml = new XmlDocument();
                xml.LoadXml(stringresponse);
                return xml;*/
                
            }
            return null;
        }
       
    }


}
