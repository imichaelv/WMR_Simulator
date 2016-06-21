using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wms_simulator.API
{

   
    class ApiCallStore : ApiCall
    {



        public void pageRequest(int page = 1, int pageLimit = 25)
        {
            Request request = new Request()
            {
                Instance = "client",
                Type = "PageRequest",
                Page = page,
                itemPageLimit = pageLimit
            };
        }
    }
}
