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
    public class SignUpManager : ISignUpService
    {
        private readonly ISignUpDal _signUpDal;

        public SignUpManager(ISignUpDal signUpDal)
        {
            _signUpDal = signUpDal;
        }

        public void Delete(User t)
        {
            _signUpDal.Delete(t);
        }

        public User GetById(int id)
        {
           return _signUpDal.GetById(id);
        }

        public List<User> GetListAll()
        {
            return _signUpDal.GetListAll();
        }

        public void Insert(User t)
        {
            _signUpDal.Insert(t);
        }

        public void Update(User t)
        {
            _signUpDal.Update(t);
        }
    }
}
