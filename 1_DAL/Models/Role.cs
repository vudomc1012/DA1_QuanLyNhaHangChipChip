using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    public partial class Role
    {
        public Role()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool? Status { get; set; }

        [InverseProperty(nameof(NhanVien.RoleNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
