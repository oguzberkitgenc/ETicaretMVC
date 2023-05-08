using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Tables;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class NetflixManager : INetflixService
	{
		private readonly INetflixDal _productDal;

		public NetflixManager(INetflixDal productDal)
		{
			_productDal = productDal;
		}

		public void Delete(Product t)
		{
			_productDal.Delete(t);
		}

		public Product GetById(int id)
		{
			return _productDal.GetById(id);
		}

		public List<Product> GetListAll()
		{
			return _productDal.GetListAll();
		}

		public void Insert(Product t)
		{
			_productDal.Insert(t);
		}

		public void Update(Product t)
		{
			_productDal.Update(t);
		}
	}
}
