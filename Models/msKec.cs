using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{
    [Table("msKec")]
    public class msKec
    {
        [Key]
        public int idKec { get; set; }
        public int idKabKot { get; set; }
        public string name { get; set; }
        public string deletedBy { get; set; }
    }
}
