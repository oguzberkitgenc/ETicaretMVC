﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Abstract.Base;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfITunesDal : GenericRepository<Product>,IITunesDal
    {
    }
}
