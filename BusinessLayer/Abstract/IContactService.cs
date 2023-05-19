using BusinessLayer.Abstract.Base;
using DataAccessLayer.Abstract.Base;
using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
    }
}
