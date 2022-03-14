using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class Khach
    {
        [Key]
        public int id { get; set; }

        public string hoTen { get; set; }

        public string soDienThoai { get; set; }
    }
}
