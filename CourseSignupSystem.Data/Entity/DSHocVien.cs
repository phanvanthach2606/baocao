using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSignupSystem.Data.Entity
{
    [Table("DSHocVien")]
    public partial class DSHocVien
    {
        public int ViewCount;

        public int id { get; set; }

        [StringLength(50)]
        public string MaHV { get; set; }

        [Column(TypeName = "text")]
        public string HinhAnh { get; set; }

        [StringLength(20)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string PhuHuynh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public int? SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
