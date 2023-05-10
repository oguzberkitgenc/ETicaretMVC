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
    public class HomePageManager : IHomePageService
    {
        private readonly IHomePageDal _homePageDal;

        public HomePageManager(IHomePageDal homePageDal)
        {
            _homePageDal = homePageDal;
        }

        public void Delete(HomePage t)
        {
            _homePageDal.Delete(t);
        }

        public HomePage GetById(int id)
        {
            return _homePageDal.GetById(id);
        }

        public List<HomePage> GetListAll()
        {
            return _homePageDal.GetListAll();
        }

        public void Insert(HomePage t)
        {
            _homePageDal.Update(t);
        }

        public void Update(HomePage t)
        {
            _homePageDal.Update(t);
        }
    }
}
