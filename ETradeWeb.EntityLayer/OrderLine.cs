using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.EntityLayer
{
    public class OrderLine : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }

        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
