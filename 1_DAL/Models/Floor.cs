using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("Floor")]
    public partial class Floor
    {
        public Floor()
        {
            BanAns = new HashSet<BanAn>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string FloorNumber { get; set; }
        public bool? Status { get; set; }

        [InverseProperty(nameof(BanAn.FloorNavigation))]
        public virtual ICollection<BanAn> BanAns { get; set; }
    }
}
