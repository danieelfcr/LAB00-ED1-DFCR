using LAB00_DFCR1117121.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB00_DFCR1117121.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public long TelNumber { get; set; }
        public string Description { get; set; }

        public static void Save(Client model)
        {
            DataManagement.Instance.clientList.Add(model);
        }
    }

}
