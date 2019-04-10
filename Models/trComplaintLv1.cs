using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{

    [Table("trComplaintLv1")]
    public class trComplaintLv1
    {

        [Key]
        public int idComplaintLv1 { get; set; }
        public int idTopics { get; set; }
        public int idComplaintSource { get; set; }

        public string complaintDate { get; set; }
        public string allocatedDate { get; set; }
        public string progressDate { get; set; }
        public string solvedDate { get; set; }
        public string allocated { get; set; }

        [Required(ErrorMessage = "Harap Isi !")]
        public string desc { get; set; }

        public string hideUser { get; set; }
        public int idUser { get; set; }
        public string namaDepan { get; set; }
        public string namaBelakang { get; set; }

        public string response { get; set; }

        public string status { get; set; }

        public int prov { get; set; }       
        public int kabkot { get; set; }        
        public int kec { get; set; }

        [Required(ErrorMessage = "Harap Isi !")]
        public string descLocation { get; set; }
        public string  deletedby { get; set; }
    }
}
