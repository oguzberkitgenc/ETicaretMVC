using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.Base
{
	public interface IGenericService<T> where T : class, new()
	{
		void Insert(T t);
		void Update(T t);
		T GetById(int id);
		void Delete(T t);
		List<T> GetListAll();

	}
}
