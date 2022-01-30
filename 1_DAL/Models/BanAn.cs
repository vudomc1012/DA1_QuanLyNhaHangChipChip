using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("BanAn")]
    [Index(nameof(Floor), Name = "IX_BanAn_Floor")]
    public partial class BanAn
    {
        public BanAn()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int? Floor { get; set; }
        [StringLength(10)]
        public string Busy { get; set; }
        public int TinhTrang { get; set; }
        public bool Status { get; set; }
        public int Rong { get; set; }
        public int Cao { get; set; }

        [ForeignKey(nameof(Floor))]
        [InverseProperty("BanAns")]
        public virtual Floor FloorNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdtableNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
