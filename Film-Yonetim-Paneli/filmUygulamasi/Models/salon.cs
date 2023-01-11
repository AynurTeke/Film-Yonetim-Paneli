using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace filmUygulamasi.Models
{
    public class salon
    {
        public int salonID { get; set; }
        [Required(ErrorMessage = "Salon adı boş bırakılamaz.")]
        [Column(TypeName = "nchar(250)")]
        [MinLength(2, ErrorMessage = "Salon adı en az iki karakterden oluşmalı.")]
        public string salonAd { get; set; }
    }
}
