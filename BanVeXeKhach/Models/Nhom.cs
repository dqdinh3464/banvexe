using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class Nhom
    {
        [Key]
        public int id { get; set; }

        public string linkNhom { get; set; }

        [ForeignKey("Khach")]
        public int idTruongNhom { get; set; }

        public Khach TruongNhom { get; set; }
    }
}
