using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseSignupSystem.Data.Entity
{
    [Table("ToBoMon")]
    public partial class ToBoMon
    {
        [Key]
        [StringLength(10)]
        public string TenToBoMon { get; set; }
    }
}
