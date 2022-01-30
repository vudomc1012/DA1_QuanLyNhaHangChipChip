using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("HoaDonChiTiet")]
    [Index(nameof(Idbill), Name = "IX_HoaDonChiTiet_IDBill")]
    [Index(nameof(Idfood), Name = "IX_HoaDonChiTiet_IDFood")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDBill")]
        public int Idbill { get; set; }
        [Column("IDFood")]
        public int Idfood { get; set; }
        public int Count { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public bool? Status { get; set; }

        [ForeignKey(nameof(Idbill))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon IdbillNavigation { get; set; }
        [ForeignKey(nameof(Idfood))]
        [InverseProperty(nameof(MonAnChiTiet.HoaDonChiTiets))]
        public virtual MonAnChiTiet IdfoodNavigation { get; set; }
    }
}
