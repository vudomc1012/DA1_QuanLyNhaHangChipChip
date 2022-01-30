using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("MonAnChiTiet")]
    [Index(nameof(Idcategory), Name = "IX_MonAnChiTiet_IDCategory")]
    [Index(nameof(Idmethod), Name = "IX_MonAnChiTiet_IDMethod")]
    [Index(nameof(Idunit), Name = "IX_MonAnChiTiet_IDUnit")]
    public partial class MonAnChiTiet
    {
        public MonAnChiTiet()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            ThucDons = new HashSet<ThucDon>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("IDUnit")]
        public int Idunit { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column("IDCategory")]
        public int Idcategory { get; set; }
        [Column("IDMethod")]
        public int Idmethod { get; set; }
        public int? Status { get; set; }
        [StringLength(500)]
        public string GhiChu { get; set; }
        [StringLength(500)]
        public string Anh { get; set; }

        [ForeignKey(nameof(Idcategory))]
        [InverseProperty(nameof(DanhMucFood.MonAnChiTiets))]
        public virtual DanhMucFood IdcategoryNavigation { get; set; }
        [ForeignKey(nameof(Idmethod))]
        [InverseProperty(nameof(CachCheBien.MonAnChiTiets))]
        public virtual CachCheBien IdmethodNavigation { get; set; }
        [ForeignKey(nameof(Idunit))]
        [InverseProperty(nameof(DonVi.MonAnChiTiets))]
        public virtual DonVi IdunitNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdfoodNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        [InverseProperty(nameof(ThucDon.IdchiTietNavigation))]
        public virtual ICollection<ThucDon> ThucDons { get; set; }
    }
}
