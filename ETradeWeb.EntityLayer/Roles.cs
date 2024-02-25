using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.EntityLayer
{
    public class Roles : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
