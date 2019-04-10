using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("msKabKot")]
    public class msKabKot
    {
        [Key]
        public int idKabKot { get; set; }
        public string name { get; set; }
        public string deletedBy { get; set; }


    }
}
