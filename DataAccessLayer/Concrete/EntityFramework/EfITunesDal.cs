﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Tables;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfITunesDal : GenericRepository<Product>,IITunesDal
    {
    }
}
