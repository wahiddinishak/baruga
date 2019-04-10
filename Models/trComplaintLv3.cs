using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("trComplaintLv3")]
    public class trComplaintLv3
    {
        [Key]
        public int idComplaintLv3 { get; set; }
        public int idComplaintLv2 { get; set; }
        public int idComplaintLv1 { get; set; }
        public int idKabKot { get; set; }
        public int idOPDKabKot { get; set; }
        public string status { get; set; }
        public string createdAt { get; set; }
        public string deletedBy { get; set; }

    }
}
