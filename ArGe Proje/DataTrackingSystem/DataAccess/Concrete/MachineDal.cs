﻿using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class MachineDal : IMachineDal
    {
        public List<Machine> GetAll()
        {
            using (DataTrackingDbContext context = new DataTrackingDbContext())
            {
                var datas = context.Set<Machine>().ToList();
                return datas;
            }
        }
    }
}
