using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{
    [Table("trComplaintPicture")]
    public class trComplaintPicture
    {
        [Key]
        public int idPicture { get; set; }
        public int idComplaint { get; set; }
        public string caption { get; set; }
        public string imgSrc { get; set; }
        public int imgStatus { get; set; }
    }
}
