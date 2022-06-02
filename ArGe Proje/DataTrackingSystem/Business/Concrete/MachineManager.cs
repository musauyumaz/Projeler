using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MachineManager : IMachineService
    {
        private readonly IMachineDal _machineDal;

        public MachineManager(IMachineDal machineDal)
        {
            _machineDal = machineDal;
        }

        public List<Machine> GetAll()
        {
           return _machineDal.GetAll();
        }
    }
}
