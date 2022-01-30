using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("DanhMucFood")]
    public partial class DanhMucFood
    {
        public DanhMucFood()
        {
            MonAnChiTiets = new HashSet<MonAnChiTiet>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool? Status { get; set; }

        [InverseProperty(nameof(MonAnChiTiet.IdcategoryNavigation))]
        public virtual ICollection<MonAnChiTiet> MonAnChiTiets { get; set; }
    }
}
