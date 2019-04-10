using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("msUsersPelapor")]
    public class msUsersPelapor
    {
        [Key]
        public int idUserPelapor { get; set; }

        [Required(ErrorMessage = "Harap Isi !")]
        public string namaDepan { get; set; }
        public string namaBelakang { get; set; }

        [Required(ErrorMessage = "Harap Isi !")]
        public string address { get; set; }

        [Required(ErrorMessage = "Harap Isi !")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Harap Isi !")]
        public string email { get; set; } 

        [Required(ErrorMessage = "Harap Isi !")]
        public string password { get; set; }

             

       
    }
}
