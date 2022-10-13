using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseSignupSystem.Data.Entity
{
    [Table("LoaiDiem")]
    public partial class LoaiDiem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiDiem { get; set; }

        [StringLength(50)]
        public string TenLoaiDiem { get; set; }

        public int? HeSo { get; set; }
    }
}
