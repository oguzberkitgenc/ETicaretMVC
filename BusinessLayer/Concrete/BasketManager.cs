using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void Delete(Basket t)
        {
            _basketDal.Delete(t);
        }

        public Basket GetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public List<Basket> GetListAll()
        {
            return _basketDal.GetListAll();
        }

        public void Insert(Basket t)
        {
            _basketDal.Insert(t);
        }

        public void Update(Basket t)
        {
            _basketDal.Update(t);
        }
    }
}
