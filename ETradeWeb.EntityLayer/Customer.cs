using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.EntityLayer
{
    public class Customer:IEntity
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Surname { get; set; }

        public string Email { get; set; }
        public string? Address { get; set; }
        public string Phone { get; set; }
       
    }
}
