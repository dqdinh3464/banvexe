using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class NhaXe
    {
        [Key]
        public int id { get; set; }

        public string bienSo { get; set; }

        public string tenNhaXe { get; set; }

        public string soDienThoai { get; set; }

        public int soGheNgoi { get; set; }

        public int soGheNam { get; set; }

        public int taiTrongMoiKhach { get; set; }

        public string thoiGianDi { get; set; }

        public virtual ICollection<DanhSachTinhXeDiQua> DanhSachTinhXeDiQua { get; set; }
    }
}
