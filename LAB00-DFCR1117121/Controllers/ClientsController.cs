using LAB00_DFCR1117121.Helpers;
using LAB00_DFCR1117121.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB00_DFCR1117121.Controllers
{
    public class ClientsController : Controller
    {
        // GET: ClientsController
        public ActionResult Index()
        {
            return View(DataManagement.Instance.clientList);  //Se utiliza /clients
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View(new Client());
        }

        public ActionResult SortByName()    //Action result al presionar el botón
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, List<Client> clientList)
        {
            try
            {
                Client.Save(new Client
                {
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    TelNumber = long.Parse(collection["TelNumber"]),
                    Description = collection["Description"],
                });
                //DataManagement.SortByName(clientList);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
