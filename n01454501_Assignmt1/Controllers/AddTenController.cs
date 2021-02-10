using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01454501_Assignmt1.Controllers
{
    public class AddTenController : ApiController
    {/// <summary>
     /// A GET request which will return 10 more than the integer input{id}
     /// </summary>
     /// <param name="id">input id</param>
     /// <returns>
     /// GET localhost/api/AddTen/21   => 31
     /// GET localhost/api/AddTen/0   => 10
     ///  GET localhost/api/AddTen/-9   => 1
     /// </returns>
        // get api/AddTen/5
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 };
        }
    }
}
