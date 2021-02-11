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
     ///  Giving out a responsive cost output based on the number of hosting days{id} by calculating the cost fortnitly  basis , providing the tax and then outputting the total   
     ///  1.approach is by dividing the total number of days with 14 days(fortnite) since the cost is 5.50$/ FN and adds up after every fortnite to get the correct number of days as an output.
     ///  2. add 1 to the total days as 14th days is charged the 2 fortnite amount as per the problem.
     ///  3.Multiply 5.50 with thetotal number of days.
     ///   4. multiply the HST with the total cost.
     ///   5. add hthe hst to the total cost to putput the total after tax
     ///   6. round all the outputs to 2 decimals to provide exact output.
     ///   7. return the output by concatination of strings and numbers as an output to the user
     ///  
     /// </summary>
     /// <param name="id">int id</param>
     /// <returns>Returns the cost based on the number of days elasped and charged on fortnitely basis(after every 14 days)</returns>
     ///  GET api/Hosting Cost/0.
        public IEnumerable<string> Get(int id)


        {
            double costPerFortnite = 5.50;
            int daysPerFortnite = 14;
            double totalDays = id / daysPerFortnite;
            totalDays++;
            double hst = 13;

            double totalCost = costPerFortnite * totalDays ;
            double hstSpecific = totalCost * hst/100;
            double totalAfterHst = totalCost + hstSpecific;
            double  hstSpecificRound = Math.Round(hstSpecific, 2);
            double totalCostRound = Math.Round(totalCost, 2);
            double totalAfterHstRound = Math.Round(totalAfterHst, 2);

            return new string[] { "1 fortnite at $5.50/FN = $" + totalCostRound + " CAD", "HST 13% = $" + hstSpecificRound + " CAD", "Total =  $" + totalAfterHstRound + " CAD" };

        

        }




    }
}
