using BanVeXeKhach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Controllers
{
    [Route("admin/tinh")]
    public class TinhController : Controller
    {
        private PostgreSQLContext db;

        public TinhController(PostgreSQLContext _db)
        {
            db = _db;
        }

        [Route("", Name = "tinh.index")]
        public IActionResult Index()
        {
            return View(db.Tinh.ToList());
        }


        [Route("them", Name = "tinh.them.get")]
        [HttpGet]
        public IActionResult Them()
        {
            return View();
        }

        [Route("them", Name = "tinh.them.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Them(Tinh tinh)
        {
            if (ModelState.IsValid)
            {
                db.Tinh.Add(tinh);
                db.SaveChanges();
                TempData["success"] = "Thêm thành công";

                return RedirectToAction("Them");
            }
            else
            {
                TempData["error"] = "Thêm thất bại";

                return View(tinh);
            }
        }

        [Route("sua/{id:int}", Name = "tinh.sua.get")]
        [HttpGet]
        public IActionResult Sua(int id)
        {
            var tinh = db.Tinh.Find(id);
            if (tinh != null)
            {
                return View(tinh);
            }

            return NotFound();
        }

        [Route("sua/{id:int}", Name = "tinh.sua.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Sua(Tinh _tinh, int id)
        {
            if (ModelState.IsValid)
            {
                var tinh = db.Tinh.Find(id);

                if (tinh != null)
                {
                    tinh.tenTinh = _tinh.tenTinh;

                    db.Entry(tinh).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["success"] = "Sửa thành công";

                    return RedirectToAction("Sua");
                }

                return NotFound();
            }
            else
            {
                TempData["error"] = "Sửa thất bại";
            }

            return View(_tinh);
        }

        [Route("xoa/{id:int}", Name = "tinh.xoa")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(int id)
        {
            var tinh = db.Tinh.Find(id);
            if (tinh != null)
            {
                db.Tinh.Remove(tinh);
                db.SaveChanges();

                TempData["success"] = "Xóa thành công";

                return RedirectToAction("Index");
            }

            return NotFound();
        }
    }
}
