using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Tables;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ISteamManager : ISteamService
    {
        private readonly ISteamDal _steamDal;

        public ISteamManager(ISteamDal steamDal)
        {
            _steamDal = steamDal;
        }

        public void Delete(Product t)
        {
            _steamDal.Delete(t);
        }

        public Product GetById(int id)
        {
            return _steamDal.GetById(id);
        }

        public List<Product> GetListAll()
        {
            return _steamDal.GetListAll();
        }

        public void Insert(Product t)
        {
            _steamDal.Insert(t);
        }

        public void Update(Product t)
        {
            _steamDal.Update(t);
        }
    }
}
