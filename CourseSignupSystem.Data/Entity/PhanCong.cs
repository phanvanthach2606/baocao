using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseSignupSystem.Data.Entity
{
    [Table("PhanCong")]
    public partial class PhanCong
    {
        [Key]
        [StringLength(50)]
        public string MaGiaoVien { get; set; }

        [StringLength(20)]
        public string TenGiangVien { get; set; }

        [StringLength(50)]
        public string MonHoc { get; set; }

        [StringLength(50)]
        public string Lop { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }
    }
}
