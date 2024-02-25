using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.EntityLayer
{
    public class Slider:IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Başlık"), StringLength(50)]
        public string? Name { get; set; }
        [Display(Name = "Açıklama"), DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [Display(Name = "Resim"), StringLength(100)]
        public string? Image { get; set; }
        [Display(Name = "Resim Link"), StringLength(100)]
        public string? Link { get; set; }
    }
}
