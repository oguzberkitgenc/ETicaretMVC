using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Base;
using DataAccessLayer.Abstract;
using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HomeManager : IHomeService
    {
        private readonly IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public void Delete(HomePage t)
        {
            _homeDal.Delete(t);
        }

        public HomePage GetById(int id)
        {
            return _homeDal.GetById(id);
        }

        public List<HomePage> GetListAll()
        {
            return _homeDal.GetListAll();
        }

        public void Insert(HomePage t)
        {
            _homeDal.Insert(t);
        }

        public void Update(HomePage t)
        {
            _homeDal.Update(t);
        }
    }
}
