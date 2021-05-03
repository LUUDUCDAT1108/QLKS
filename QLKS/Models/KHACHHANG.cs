using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKS.Models
{
    [Table("KHACHHANGS")]
    public class KHACHHANG
    {
        [Key]
        public String MaKH { get; set; }
        [AllowHtml]
        public String HoTenKH { get; set; }
        public String SoDT { get; set; }
        public int CMCC { get; set; }
        public String PhanLoaiKH { get; set; }
    }
}