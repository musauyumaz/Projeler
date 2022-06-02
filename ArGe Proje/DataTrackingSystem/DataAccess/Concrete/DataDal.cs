using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DataDal : IDataDal
    {
        public List<Data> GetAllDataByMachine(int machineId)
        {
            using (DataTrackingDbContext context = new DataTrackingDbContext())
            {
                var data = context.Set<Data>().Where(x=>x.MachineId == machineId).ToList();
                return data;
            }
            
        }

        public Data GetLastData(int machineId)
        {
            using (DataTrackingDbContext context = new DataTrackingDbContext())
            {
                var data = context.Data.Where(x=>x.MachineId == machineId).OrderByDescending(x=>x.Id).FirstOrDefault();
                return data;
            }
        }
    }
}
