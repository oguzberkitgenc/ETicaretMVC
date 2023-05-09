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
    public class AdresManager : IAdresService
    {
        private readonly IAdresDal _adresDal;

        public AdresManager(IAdresDal adresDal)
        {
            _adresDal = adresDal;
        }

        public void Delete(Adress t)
        {
            _adresDal.Delete(t);
        }

        public Adress GetById(int id)
        {
           return _adresDal.GetById(id);
        }

        public List<Adress> GetListAll()
        {
            return _adresDal.GetListAll();
        }

        public void Insert(Adress t)
        {
            _adresDal.Insert(t);
        }

        public void Update(Adress t)
        {
            _adresDal.Update(t);
        }
    }
}
