using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Xml;

namespace wms_simulator.API
{
    public interface ApiCallInterface
    {
        Task<XmlDocument> post(string apiLocation, Request request);
    }
}
