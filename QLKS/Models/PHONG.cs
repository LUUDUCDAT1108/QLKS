using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLKS.Models
{
    [Table("PHONGS")]
    public class PHONG
    {
        [Key]
        public String MaPhong { get; set; }
        public String TenPhong { get; set; }
        public String LoaiPhong { get; set; }
        public String TrangThai { get; set; }
        public float GiaPhong { get; set; }
    }
}