using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Tables;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class IAdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public IAdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Delete(Admin t)
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Admin t)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}
