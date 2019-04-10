using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("trComplaintLv2")]
    public class trComplaintLv2
    {
        [Key]
        public int idComplaintLv2 { get; set; }
        public int idComplaintLv1 { get; set; }
        public string allocationStatus { get; set; }
        public string allocationType { get; set; }
        public int allocated { get; set; }
        public int idOPD { get; set; }
        public string status { get; set; }
        public string createdAt { get; set; }
        public string deletedBy { get; set; }
    }
}
