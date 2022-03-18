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

        private string CreateMD5()
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(DateTime.Now.ToString());
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
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
                khach.truongNhom = true;
                db.Khach.Add(khach);
                db.SaveChanges();

                khach.maNhom = CreateMD5();
                db.Entry(khach).State = EntityState.Modified;
                db.SaveChanges();

                return Json(new { data = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}" + Url.RouteUrl("dat_ve.nhom.get", new { ma_nhom = khach.maNhom }), status = "success" });
            }

            IEnumerable<string> allErrors = ModelState.Values.SelectMany(v => v.Errors.Select(b => b.ErrorMessage));

            return Json(new { data = allErrors.First(), status = "error" });
        }

        [Route("nhom/{ma_nhom}", Name = "dat_ve.nhom.get")]
        [HttpGet]
        public async Task<IActionResult> DatVeNhom(string ma_nhom)
        {
            Khach khach = await db.Khach.Where(s => s.maNhom == ma_nhom).Where(s => s.truongNhom == true).Include(s => s.Tinh).FirstOrDefaultAsync();
            if (khach != null)
            {
                ViewBag.DSTinh = new SelectList(db.Tinh, "id", "tenTinh");
                ViewBag.DSKhachDatVeNhom = await db.Khach.Where(s => s.maNhom == khach.maNhom).Include(s => s.Tinh).ToListAsync();
                ViewBag.DSTinhKhachDi = await db.Khach.Where(s => s.maNhom == khach.maNhom).Select(s => s.Tinh.id).Distinct().ToListAsync();
                ViewBag.DSNhaXe = await db.NhaXe.ToListAsync();

                return View();
            }

            return NotFound();
        }

        [Route("nhom/{ma_nhom}", Name = "dat_ve.nhom.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DatVeNhom(Khach khach, string ma_nhom)
        {
            if (ModelState.IsValid)
            {
                Khach truong_nhom = await db.Khach.Where(s => s.maNhom == ma_nhom).FirstAsync();
                if (truong_nhom != null)
                {
                    int count = await db.Khach.Where(s => s.maNhom == truong_nhom.maNhom).CountAsync();
                    if(count < 8)
                    {
                        khach.maNhom = truong_nhom.maNhom;
                        await db.Khach.AddAsync(khach);
                        await db.SaveChangesAsync();

                        TempData["success"] = "Đặt vé thành công";
                    }
                    else
                    {
                        TempData["error"] = "Đặt vé thất bại";
                    }

                    return RedirectToRoute("dat_ve.nhom.get", new { id = truong_nhom.maNhom });
                }
            }

            return NotFound();
        }
    }
}
