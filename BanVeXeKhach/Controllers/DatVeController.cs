using BanVeXeKhach.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Controllers
{
    [Route("dat-ve")]
    public class DatVeController : Controller
    {
        public PostgreSQLContext db;
        public DatVeController(PostgreSQLContext _db)
        {
            db = _db;
        }

        [Route("", Name = "dat_ve.index")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DSTinh = db.Tinh.ToList();
            return View();
        }

        [Route("", Name = "dat_ve.post")]
        [HttpPost]
        public IActionResult DatVe()
        {
            return View();
        }
    }
}
