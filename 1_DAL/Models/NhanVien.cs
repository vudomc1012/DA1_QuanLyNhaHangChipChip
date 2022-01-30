using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("NhanVien")]
    [Index(nameof(Role), Name = "IX_NhanVien_Role")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("MaNV")] public string MaNv { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(500)]
        public string Password { get; set; }
        public int Role { get; set; }
        public bool? Status { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        [Required]
        [StringLength(500)]
        public string Address { get; set; }
        [Required]
        [StringLength(12)]
        public string PhoneNo { get; set; }

        [ForeignKey(nameof(Role))]
        [InverseProperty("NhanViens")]
        public virtual Role RoleNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdnhanVienNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
