using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace filmUygulamasi.Models
{
    public class film
    {
        public int filmID { get; set; }

        [Required(ErrorMessage = "Film adı boş bırakılamaz.")]
        [Column(TypeName = "nchar(250)")]
        public string filmAd { get; set; }

        [Required]
        public int filmYapimYil { get; set; }

    }
}
