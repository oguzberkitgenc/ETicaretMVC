using DataAccessLayer.Abstract.Base;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {

        public void Delete(T t)
        {
            using var context = new ETicaretContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            //return context.Set<T>().ToList()[id];  dene bunu
            using var context = new ETicaretContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new ETicaretContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new ETicaretContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new ETicaretContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
