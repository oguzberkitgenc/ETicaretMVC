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
    public class ITunesManager : IITunesService
    {
        private readonly IITunesDal _itunesDal;

        public ITunesManager(IITunesDal itunesDal)
        {
            _itunesDal = itunesDal;
        }

        public void Delete(Product t)
        {
            _itunesDal.Delete(t);
        }

        public Product GetById(int id)
        {
            return _itunesDal.GetById(id);
        }

        public List<Product> GetListAll()
        {
            return _itunesDal.GetListAll();
        }

        public void Insert(Product t)
        {
            _itunesDal.Insert(t);
        }

        public void Update(Product t)
        {
            _itunesDal.Update(t);
        }
    }
}
