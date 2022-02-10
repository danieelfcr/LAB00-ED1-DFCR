using LAB00_DFCR1117121.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LAB00_DFCR1117121.Models
{
    public class Client
    {
       [Range(2,20)]
        public string Name { get; set; }
        [Range(2, 20)]
        public string LastName { get; set; }
        [Range(10000000,99999999)]
        public long TelNumber { get; set; }
        public string Description { get; set; }

        public static void Save(Client model)
        {
            DataManagement.Instance.clientList.Add(model);
        }
    }

}
