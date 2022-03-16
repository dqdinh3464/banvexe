using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    
    public class DanhSachTinhXeDiQua
    {
        [Display(Name = "Nhà xe")]
        [ForeignKey("NhaXe")]
        [Required(ErrorMessage = "Nhà xe không được để trống")]
        public int idNhaXe { get; set; }

        [Display(Name = "Tỉnh")]
        [ForeignKey("Tinh")]
        [Required(ErrorMessage = "Tỉnh không được để trống")]
        public int idTinh { get; set; }

        [Display(Name = "Thứ tự")]
        [Required(ErrorMessage = "Thứ tự không được để trống")]
        public int thuTu { get; set; }

        [Display(Name = "Giá vé")]
        [Required(ErrorMessage = "Giá vé không được để trống")]
        public int giaVe { get; set; }

        public NhaXe NhaXe { get; set; }

        public Tinh Tinh { get; set; }
    }
}
