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
    public class DataManager : IDataService
    {
        private readonly IDataDal _dataDal;

        public DataManager(IDataDal dataDal)
        {
            _dataDal = dataDal;
        }

        public List<Data> GetAllDataByMachine(int machineId)
        {
           return _dataDal.GetAllDataByMachine(machineId);
        }

        public Data GetLastDataByMachine(int machineId)
        {
            return _dataDal.GetLastData(machineId);
        }
    }
}
