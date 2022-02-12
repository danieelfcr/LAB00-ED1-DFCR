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
        [Required(ErrorMessage = "Write the name")]
        [MaxLength(20)]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Write the last name")]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Write the phone number")]
        [Range(10000000, 99999999)]  //Rango para que el teléfono solo tenga 8 dígitos.
        public long TelNumber { get; set; }
        public string Description { get; set; }

        public static void Save(Client model)
        {
            DataManagement.Instance.clientList.Add(model);
        }

        public static void sortName()
        {
            for (int i = 0; i < DataManagement.Instance.clientList.Count; i++)
            {
                for (int j = 0; j < DataManagement.Instance.clientList.Count - 1 - i; j++)
                {
                    int x = DataManagement.Instance.clientList[j].Name.CompareTo(DataManagement.Instance.clientList[j + 1].Name);
                    if (x > 0)
                    {
                        var aux = DataManagement.Instance.clientList[j + 1];
                        DataManagement.Instance.clientList[j + 1] = DataManagement.Instance.clientList[j];
                        DataManagement.Instance.clientList[j] = aux;
                    }
                }
            }
        }

        public static void sortLastName()
        {
            for (int i = 0; i < DataManagement.Instance.clientList.Count; i++)
            {
                for (int j = 0; j < DataManagement.Instance.clientList.Count - 1 - i; j++)
                {
                    int x = DataManagement.Instance.clientList[j].LastName.CompareTo(DataManagement.Instance.clientList[j + 1].LastName);
                    if (x > 0)
                    {
                        var aux = DataManagement.Instance.clientList[j + 1];
                        DataManagement.Instance.clientList[j + 1] = DataManagement.Instance.clientList[j];
                        DataManagement.Instance.clientList[j] = aux;
                    }
                }
            }
        }
    }

}
