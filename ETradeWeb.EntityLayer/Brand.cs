using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.EntityLayer
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Ad"), StringLength(50)]

        public string? Name { get; set; }
    
        public string? Logo { get; set; }
     

        
    }
}
