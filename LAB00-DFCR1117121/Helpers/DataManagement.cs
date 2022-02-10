using LAB00_DFCR1117121.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB00_DFCR1117121.Helpers
{
    public class DataManagement
    {
        private static DataManagement _instance = null;

        public static DataManagement Instance
        {
            get {
                if (_instance == null)  //Si es primera solicitud == null
                {
                    _instance = new DataManagement();
                }
                return _instance;
                    }

        }

        public List<Client> clientList = new List<Client>
        {
          
        };

        public static void SortByName(List<Client> clientList)
        {
            IEnumerable<Client> SortedListClient = clientList.OrderBy(x => x.Name);
            
        }

    }
}
