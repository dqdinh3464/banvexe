using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class Tinh
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Tỉnh không được để trống")]
        [MaxLength(32, ErrorMessage = "Tài khoản chỉ được phép có tối đa 32 ký tự")]
        public string tenTinh { get; set; }

        public virtual ICollection<DanhSachTinhXeDiQua> DanhSachTinhXeDiQua { get; set; }
    }
}
