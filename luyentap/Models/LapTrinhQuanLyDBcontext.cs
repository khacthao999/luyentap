using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace luyentap.Models
{
    public class LapTrinhQuanLyDBcontext: DbContext
    {
        public LapTrinhQuanLyDBcontext() : base("LapTrinhQuanLyDBcontext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Sinhvien> SinhViens { get; set; }

    }
}
//LAPTOP-R53ULTAE\SQLEXPRESS