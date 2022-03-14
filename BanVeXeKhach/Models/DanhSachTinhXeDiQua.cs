using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    
    public class DanhSachTinhXeDiQua
    {
        [Key]
        public int id { get; set; }

        public int idNhaXe { get; set; }

        public int idTinh { get; set; }

        public int thuTu { get; set; }

        public int giaVe { get; set; }

        public NhaXe NhaXe { get; set; }

        public Tinh Tinh { get; set; }
    }
}
