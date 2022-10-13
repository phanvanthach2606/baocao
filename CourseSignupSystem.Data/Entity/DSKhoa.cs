using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseSignupSystem.Data.Entity
{
    [Table("DSKhoa")]
    public partial class DSKhoa
    {
        [Key]
        [StringLength(50)]
        public string MaKhoa { get; set; }

        [StringLength(50)]
        public string TenKhoa { get; set; }
    }
}
