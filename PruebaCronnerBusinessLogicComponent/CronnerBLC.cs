using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaCronnerBusinessLogicComponent
{
    public class CronnerBLC
    {

        PLMClientsEngine.PLMClientsClient c = new PLMClientsEngine.PLMClientsClient();

        public List<PLMClientsEngine.CountryInfo> getCountries()
        {
            return c.getCountries();
        }

        //public static readonly CronnerBLC Instance = new CronnerBLC();
        
    }
}
