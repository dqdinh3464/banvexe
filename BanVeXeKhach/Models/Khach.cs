using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class Khach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string hoTen { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"0[1-9][0-9]{8}", ErrorMessage = "Số điện thoại không đúng định dạng. Ví dụ: 0839014065")]
        public string soDienThoai { get; set; }

        [Display(Name = "Mã nhóm")]
        public string maNhom { get; set; }

        [Display(Name = "Trưởng nhóm")]
        public bool truongNhom { get; set; }

        [Display(Name = "Tỉnh")]
        public int idTinh { get; set; }

        public Tinh Tinh { get; set; }
    }
}
