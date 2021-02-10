using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01454501_Assignmt1.Controllers
{
    public class HostingCostController : ApiController
    {/// <summary>
     ///  Add the cost per fortnite to the     
     /// </summary>
     /// <param name="id"></param>
     /// <returns></returns>
        public IEnumerable<string> Get(int id)


        {
            double costPerFortnite = 5.50;
            int daysPerFortnite = 14;
            double totalDays = id / daysPerFortnite ;
            double hst = 13;

            double totalCost = costPerFortnite + totalDays;
            double hstSpecific = totalCost * hst/100;
            double totalAfterHst = totalCost + hstSpecific;
            double  hstSpecificRound = hstSpecific;

            return new string[] { "1 fortnite at $5.50/FN = $" + totalCost + " CAD", "HST 13% = $" + hstSpecificRound + " CAD", "Total =  $" + totalAfterHst + " CAD" };



        }




    }
}
