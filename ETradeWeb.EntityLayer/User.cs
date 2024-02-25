using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeWeb.EntityLayer
{
     public class User:IEntity
    {
        public int Id { get; set; }
        [Display(Name="Adı")]
        public string? Name { get; set; }
        [Display(Name = "Soyad")]
        public string? Surname { get; set; }
        public string? Email { get; set; }
        [Display(Name = "Telefon")]
        public string? Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool AktifMi { get; set; }

        public int RolesId { get; set; }
        public virtual Roles Roles { get; set; }
    }
}

