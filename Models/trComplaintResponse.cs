using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("trComplaintResponse")]
    public class trComplaintResponse
    {
        [Key]
        public int idComplaintResponse { get; set; }
        public int idComplaintLv1 { get; set; }
        public int from { get; set; }
        public string response { get; set; }
        public string createdAt { get; set; }

    }
}
