using DatasetService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            GetDBData objDB = new GetDBData();
            var result = objDB.GetAllData();
           return View("List",result.CheeseDirectory);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            GetDBData objDB = new GetDBData();
            var result = objDB.GetDataById(id);
            return View("Index", result.CheeseDirectory.FirstOrDefault());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            GetDBData objDB = new GetDBData();
            var result = objDB.GetDataById(id);
            return View("Edit", result.CheeseDirectory.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Edit(Cheese ches)
        {
            GetDBData objDB = new GetDBData();
            ches.LastUpdateDate = DateTime.Now;
            var result = objDB.InsertUpdateData(ches);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cheese ches)
        {
            GetDBData objDB = new GetDBData();
            ches.LastUpdateDate = DateTime.Now;
            var result = objDB.InsertUpdateData(ches);
            return RedirectToAction("Index");
        }

        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            GetDBData objDB = new GetDBData();
            var result = objDB.DeleteById(id);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAll()
        {
            GetDBData objDB = new GetDBData();
            var result = objDB.DeleteAll();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult FetchDataFromWeb()
        {
            DeleteAll();
            FetchData objDataAccess = new FetchData();
            var data = objDataAccess.GetDataFromWeb();
            var res = objDataAccess.InsertBulkData(data.Result);
            return View("FetchData", res.Result);
        }
    }
}
