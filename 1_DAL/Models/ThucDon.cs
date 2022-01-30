using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("ThucDon")]
    [Index(nameof(IdchiTiet), Name = "IX_ThucDon_IDChiTiet")]
    public partial class ThucDon
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDChiTiet")]
        public int IdchiTiet { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public bool? Status { get; set; }

        [ForeignKey(nameof(IdchiTiet))]
        [InverseProperty(nameof(MonAnChiTiet.ThucDons))]
        public virtual MonAnChiTiet IdchiTietNavigation { get; set; }
    }
}
