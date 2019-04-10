using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("msOPDProv")]
    public class msOPDProv
    {
        [Key]
        public int idOPDProv { get; set; }
        public string name { get; set; }
        public string deletedBy { get; set; }

    }
}
