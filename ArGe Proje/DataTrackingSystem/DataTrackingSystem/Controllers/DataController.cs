using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTrackingSystem.Controllers
{
    public class DataController : Controller
    {
        DataManager dataManager = new DataManager(new DataDal());
        public IActionResult Index(int machineId)
        {
            var data = dataManager.GetLastDataByMachine(machineId);
            return View(data);
        }
    }
}
