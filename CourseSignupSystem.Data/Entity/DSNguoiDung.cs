using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSignupSystem.Data.Entity
{
    [Table("DSNguoiDung")]
    public partial class DSNguoiDung
    {
        [Key]
        [StringLength(20)]
        public string TenNguoiDung { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Role { get; set; }
    }
}
