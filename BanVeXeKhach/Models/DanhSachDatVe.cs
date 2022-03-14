using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class DanhSachDatVe
    {
        [Key]
        public int id { get; set; }

        public int idKhach { get; set; }

        public int idNhaXe { get; set; }

        public int idTinh { get; set; }

        public Khach Khach { get; set; }

        public NhaXe NhaXe { get; set; }

        public Tinh Tinh { get; set; }
    }
}
