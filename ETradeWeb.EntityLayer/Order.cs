using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.EntityLayer
{
    public class Order:IEntity
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }

        public string Customer { get; set; }
        public string AdresDes { get; set; }
        public string Adres { get; set; }
        public string City { get; set; }
      
        public string Phone { get; set; }
        public virtual List<OrderLine>? OrderLines { get; set; }
    }
    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Waiting,

        [Display(Name = "Tamamlandı")]
        Completed
    }
}

