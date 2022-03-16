using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class VeNhom
    {
        [ForeignKey("Khach")]
        public int idKhach { get; set; }

        [ForeignKey("Nhom")]
        public int idNhom { get; set; }

        public Khach Khach { get; set; }
        public Nhom Nhom { get; set; }
    }
}
