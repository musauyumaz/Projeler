using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTrackingSystem.Controllers
{
    public class MachineController : Controller
    {
        MachineManager machineManager = new MachineManager(new MachineDal());
        DataManager dataManager = new DataManager(new DataDal());
        public IActionResult Index()
        {
            var machines = machineManager.GetAll();
            return View(machines);
        }
        [HttpGet]
        public IActionResult MakineVeriDetaylari(int id) 
        {
            var dataDetails = dataManager.GetLastDataByMachine(id);
            return View(dataDetails);
        }
    }
}
