namespace HD_admin.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(50)]
        public string MaSP { get; set; }

        [StringLength(50)]
        [DisplayName("Tên SP")]
        public string TenSP { get; set; }
        [DisplayName("Mô tả")]
        public string MoTa { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }
    }
}
