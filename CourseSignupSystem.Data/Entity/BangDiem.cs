using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseSignupSystem.Data.Entity
{
    [Table("BangDiem")]
    public class BangDiem
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        public int? KiemTraMieng { get; set; }

        public int? DiemTrungBinh { get; set; }
    }

}
