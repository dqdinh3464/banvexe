using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class DanhSachDatVe
    {
        [Display(Name = "Khách")]
        public int idKhach { get; set; }

        [Display(Name = "Nhà xe")]
        public int idNhaXe { get; set; }

        [Display(Name = "Nhóm")]
        public string maNhom { get; set; }

        public Khach Khach { get; set; }

        public NhaXe NhaXe { get; set; }
    }
}
