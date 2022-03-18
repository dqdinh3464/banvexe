using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class Tinh
    {
        [Display(Name = "Mã tỉnh")]
        [Key]
        public int id { get; set; }

        [Display(Name = "Tên tỉnh")]
        [Required(ErrorMessage = "Tỉnh không được để trống")]
        [MaxLength(32, ErrorMessage = "Tài khoản chỉ được phép có tối đa 32 ký tự")]
        public string tenTinh { get; set; }

        public virtual IList<DanhSachTinhXeDiQua> DanhSachXeDiQuaTinh { get; set; }
    }
}
