using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLKS.Models
{
    [Table("THUEPHONGS")]
    public class THUEPHONG
    {
        [Key]
        public String MaKH { get; set; }
        public String NgayDen { get; set; }
        public String NgayDi { get; set; }
        public float ThanhToan { get; set; }
    }
}