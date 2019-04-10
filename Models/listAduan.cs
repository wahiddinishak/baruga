using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barugaWeb.Models
{
    public class listAduan
    {
        [Key]
        public int ID { get; set; }
        public string createdDate { get; set; }
        public string allocatedDate { get; set; }
        public string progressDate { get; set; }
        public string solvedDate { get; set; }
        public string Topics { get; set; }
        public string Desc { get; set; }
        public string Hide { get; set; }
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public string response { get; set; }
        public string Status { get; set; }

    }

}
