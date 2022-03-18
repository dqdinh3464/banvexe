using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class NhaXe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        [Display(Name = "Biển số")]
        [Required(ErrorMessage = "Biển số không được để trống")]
        public string bienSo { get; set; }

        [Display(Name = "Tên nhà xe")]
        [Required(ErrorMessage = "Tên nhà xe không được để trống")]
        public string tenNhaXe { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"0[1-9][0-9]{8}", ErrorMessage = "Số điện thoại không đúng định dạng. Ví dụ: 0839014065")]
        public string soDienThoai { get; set; }

        [Display(Name = "Số ghế ngồi")]
        [Required(ErrorMessage = "Số ghế ngồi không được để trống")]
        public int soGheNgoi { get; set; }

        [Display(Name = "Số ghế nằm")]
        [Required(ErrorMessage = "Số ghế nằm không được để trống")]
        public int soGheNam { get; set; }

        [Display(Name = "Tải trọng mỗi khách")]
        [Required(ErrorMessage = "Tải trọng mỗi khách không được để trống")]
        public int taiTrongMoiKhach { get; set; }

        [Display(Name = "Thời gian đi")]
        [Required(ErrorMessage = "Thời gian đi không được để trống")]
        public string thoiGianDi { get; set; }

        [Display(Name = "Lộ trình")]
        public virtual IList<DanhSachTinhXeDiQua> DanhSachTinhXeDiQua { get; set; }

        public virtual IList<DanhSachDatVe> DanhSachDatVe { get; set; }
    }
}
