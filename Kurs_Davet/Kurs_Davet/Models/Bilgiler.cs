using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;

namespace Kurs_Davet.Models
{
    public class Bilgiler
    {

        [Required (ErrorMessage = "Lütfen Ad alanını boş bırakmayın!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen Soyad alanını boş bırakmayın!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen Email alanını boş bırakmayın!")]
        [EmailAddress] //format kontrolü
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon alanını boş bırakmayın!")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Lütfen bir seçim yapınız!")]
        public bool? Katilim { get; set; }



    }
}
