using BanVeXeKhach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.DSTinh = new SelectList(db.Tinh, "id", "tenTinh");
            return View();
        }

        [Route("", Name = "dat_ve.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult DatVe(Khach khach)
        {
            if (ModelState.IsValid)
            {
                db.Khach.Add(khach);
                db.SaveChanges();

                Nhom nhom = new Nhom();
                nhom.idTruongNhom = khach.id;
                db.Nhom.Add(nhom);
                db.SaveChanges();

                VeNhom ve_nhom = new VeNhom();
                ve_nhom.idKhach = khach.id;
                ve_nhom.idNhom = nhom.id;
                db.VeNhom.Add(ve_nhom);
                db.SaveChanges();

                nhom.linkNhom = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}" + Url.RouteUrl("dat_ve.nhom.get", new { id = nhom.id });
                db.Entry(nhom).State = EntityState.Modified;
                db.SaveChanges();

                return Json(new { data = nhom.linkNhom, status = "success" });
            }

            return Json(new { data = "", status = "error" });
        }

        [Route("nhom/{id:int}", Name = "dat_ve.nhom.get")]
        [HttpGet]
        public IActionResult DatVeNhom(int id)
        {
            Nhom nhom = db.Nhom.Find(id);
            if (nhom != null)
            {
                Khach khach = db.Khach.Where(s => s.id == nhom.idTruongNhom).Include(s => s.Tinh).FirstOrDefault();
                ViewBag.Khach = khach;
                ViewBag.DSTinh = new SelectList(db.Tinh, "id", "tenTinh");
                ViewBag.soNguoiDatVe = db.VeNhom.Where(s => s.idNhom == nhom.id).Count();

                return View();
            }

            return NotFound();
        }

        [Route("nhom/{id:int}", Name = "dat_ve.nhom.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DatVeNhom(Khach khach, int id)
        {
            if (ModelState.IsValid)
            {
                Nhom nhom = db.Nhom.Find(id);
                if (nhom != null)
                {
                    int count = db.VeNhom.Where(s => s.idNhom == nhom.id).Count();
                    if(count < 8)
                    {
                        db.Khach.Add(khach);
                        await db.SaveChangesAsync();

                        VeNhom ve_nhom = new VeNhom();
                        ve_nhom.idKhach = khach.id;
                        ve_nhom.idNhom = nhom.id;
                        db.VeNhom.Add(ve_nhom);
                        await db.SaveChangesAsync();

                        TempData["success"] = "Đặt vé thành công";
                    }
                    else
                    {
                        TempData["error"] = "Đặt vé thất bại";
                    }

                    return RedirectToRoute("dat_ve.nhom.get", new { id = id});
                }
            }

            return NotFound();
        }
    }
}
