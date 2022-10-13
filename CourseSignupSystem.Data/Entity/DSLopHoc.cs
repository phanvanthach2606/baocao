using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseSignupSystem.Data.Entity
{
    public partial class DSLopHoc
    {
        [Key]
        [StringLength(50)]
        public string TenLop { get; set; }

        [StringLength(100)]
        public string MoTa { get; set; }
    }
}
