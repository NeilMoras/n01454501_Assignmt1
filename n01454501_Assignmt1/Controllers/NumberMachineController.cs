using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01454501_Assignmt1.Controllers
{
    public class NumberMachineController : ApiController
    {/// <summary>
     /// /Creating methond which has gfour mathematical operators in it.
     /// </summary>
     /// <param name="id">input id</param>
     /// <returns> 
     /// input id{10} ->    32
     /// input  id{-5} - >  -17
     /// input id{30}  ->    99
     /// </returns>
        // GET api/NumberMachine/10
        public IEnumerable<int> Get(int id)
        {
            return new int[] { (id * 10)/ 3 + 5  -6 };
        }

    

    }
}
