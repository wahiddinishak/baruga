using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("trLIke")]
    public class trLilke
    {
        public int? id { get; set; }
        public int? idComplaint { get; set; }
        public int? idUser { get; set; }
    }
}
