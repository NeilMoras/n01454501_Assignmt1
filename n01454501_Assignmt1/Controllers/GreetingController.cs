using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01454501_Assignmt1.Controllers
{
    public class GreetingController : ApiController
    {/// <summary>
    /// /POST request which
    /// returns the string "Hello World" on Command line
    /// </summary>
    /// <returns> api/Greeting   =>    "Hello World</returns>
    /// 
      // POST api/Greeting
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns the string by concatination of the string with an interger to make it a string with the number of people chaging with the desired id input
        /// </summary>
        /// <param name="id"> inpur id</param>
        /// <returns>
        /// api/Greeting/5  => "Greetings to 5 people"
        /// </returns>
        // GET api/Greeting/5
        public string Get(int id)
        {
            return "Greetings to " + id.ToString() +" people";
        }




    }
}
