using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSignupSystem.Data.Entity
{

    [Table("DSVaiTro")]
    public partial class DSVaiTro
    {
        [Key]
        [StringLength(10)]
        public string TenVaiTro { get; set; }
    }
}
