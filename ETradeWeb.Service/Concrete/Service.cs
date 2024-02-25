using ETradeWeb.DataLayer;
using ETradeWeb.DataLayer.Concrete;
using ETradeWeb.EntityLayer;
using ETradeWeb.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext _context) : base(_context)
        {
        }


    }
    }

