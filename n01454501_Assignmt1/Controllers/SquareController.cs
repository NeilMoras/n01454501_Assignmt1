using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01454501_Assignmt1.Controllers
{
    public class SquareController : ApiController
    {/// <summary>
    /// Reutrns the square of the integer input {id}
    /// </summary>
    /// <param name="id">input int id</param>
    /// <returns>
    /// GET localhost/Square/2  => 4
    /// GET localhost/Square/-2  => 4
    /// GET localhost/Square/10   => 100
    /// </returns>
    /// //GET api/Square/5
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }

    }
}
