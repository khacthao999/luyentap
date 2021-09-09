using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace luyentap.Models
{
    public class Sinhvien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
    }
}