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
    [Route("admin/nha-xe")]
    public class NhaXeController : Controller
    {
        private PostgreSQLContext db;

        public NhaXeController(PostgreSQLContext _db)
        {
            db = _db;
        }

        private List<SelectListItem> getDSTinh()
        {
            List<Tinh> _dsTinh = db.Tinh.OrderBy(s => s.tenTinh).ToList();
            List<SelectListItem> dsTinh = new List<SelectListItem>();

            foreach (var item in _dsTinh)
            {
                dsTinh.Add(new SelectListItem { Value = item.id.ToString(), Text = item.tenTinh });
            }

            return dsTinh;
        }

        [Route("", Name = "nha_xe.index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.NhaXe.ToListAsync());
        }


        [Route("them", Name = "nha_xe.them.get")]
        [HttpGet]
        public IActionResult Them()
        {
            return View();
        }

        [Route("them", Name = "nha_xe.them.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Them(NhaXe tinh)
        {
            if (ModelState.IsValid)
            {
                db.NhaXe.Add(tinh);
                await db.SaveChangesAsync();
                TempData["success"] = "Thêm thành công";

                return RedirectToAction("Them");
            }

            TempData["error"] = "Thêm thất bại";

            return View(tinh);
        }

        [Route("sua/{id:int}", Name = "nha_xe.sua.get")]
        [HttpGet]
        public async Task<IActionResult> Sua(int id)
        {
            var tinh = await db.NhaXe.FindAsync(id);
            if (tinh != null)
            {
                return View(tinh);
            }

            return NotFound();
        }

        [Route("sua/{id:int}", Name = "nha_xe.sua.post")]
        [HttpPost]
        public async Task<IActionResult> Sua(NhaXe _nha_xe, int id)
        {
            if (id != _nha_xe.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var nha_xe = db.NhaXe.Find(id);

                if (nha_xe != null)
                {
                    nha_xe.bienSo = _nha_xe.bienSo;
                    nha_xe.tenNhaXe = _nha_xe.tenNhaXe;
                    nha_xe.soDienThoai = _nha_xe.soDienThoai;
                    nha_xe.soGheNgoi = _nha_xe.soGheNgoi;
                    nha_xe.soGheNam = _nha_xe.soGheNam;
                    nha_xe.taiTrongMoiKhach = _nha_xe.taiTrongMoiKhach;
                    nha_xe.thoiGianDi = _nha_xe.thoiGianDi;

                    db.Entry(nha_xe).State = EntityState.Modified;
                    await db.SaveChangesAsync();

                    TempData["success"] = "Sửa thành công";

                    return RedirectToAction("Sua");
                }

                return NotFound();
            }
            else
            {
                TempData["error"] = "Sửa thất bại";
            }

            return View(_nha_xe);
        }

        [Route("xoa/{id:int}", Name = "nha_xe.xoa")]
        [HttpPost]
        public async Task<IActionResult> Xoa(int id)
        {
            var nha_xe = db.NhaXe.Find(id);
            if (nha_xe != null)
            {
                db.NhaXe.Remove(nha_xe);
                await db.SaveChangesAsync();

                TempData["success"] = "Xóa thành công";

                return RedirectToAction("Index");
            }

            return NotFound();
        }


        [Route("{id:int}", Name = "nha_xe.lo_trinh")]
        [HttpGet]
        public async Task<IActionResult> IndexLoTrinhXe(int id)
        {
            var nha_xe = db.NhaXe.Find(id);
            if (nha_xe != null)
            {
                ViewData["IdNhaXe"] = id;

                return View(await db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == id).OrderBy(s => s.thuTu).Include(s => s.NhaXe).Include(s => s.Tinh).AsNoTracking().ToListAsync());
            }

            return NotFound();
        }

        [Route("{id:int}/them", Name = "nha_xe.lo_trinh.them.get")]
        [HttpGet]
        public async Task<IActionResult> ThemLoTrinhXe(int id)
        {
            var nha_xe = await db.NhaXe.FindAsync(id);
            if (nha_xe != null)
            {
                ViewData["IdNhaXe"] = id;
                ViewData["DSTinh"] = getDSTinh();

                return View();
            }

            return NotFound();
        }

        [Route("{id:int}/them", Name = "nha_xe.lo_trinh.them.post")]
        [HttpPost]
        public async Task<IActionResult> ThemLoTrinhXe(DanhSachTinhXeDiQua lo_trinh_xe, int id)
        {
            if (id != lo_trinh_xe.idNhaXe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.DanhSachTinhXeDiQua.Add(lo_trinh_xe);
                    await db.SaveChangesAsync();
                    TempData["success"] = "Thêm thành công";

                    return RedirectToAction("ThemLoTrinhXe");
                }
                catch(DbUpdateException)
                {
                    ModelState.AddModelError("", "Lỗi: Thêm thất bại");

                    return View(lo_trinh_xe);
                }
            }
            else
            {
                TempData["error"] = "Thêm thất bại";

                return View(lo_trinh_xe);
            }
        }

        [Route("{id:int}/sua/{id_lo_trinh:int}", Name = "nha_xe.lo_trinh.sua.get")]
        [HttpGet]
        public async Task<IActionResult> SuaLoTrinhXe(int id, int id_lo_trinh)
        {
            DanhSachTinhXeDiQua lo_trinh_xe = await db.DanhSachTinhXeDiQua.Where(s => s.id == id_lo_trinh).Where(s => s.idNhaXe == id).FirstAsync();
            if (lo_trinh_xe != null)
            {
                ViewData["IdNhaXe"] = id;
                ViewData["DSTinh"] = new SelectList(db.Tinh, "id", "tenTinh");

                return View(lo_trinh_xe);
            }

            return NotFound();
        }

        [Route("{id:int}/{id_lo_trinh:int}", Name = "nha_xe.lo_trinh_xe.sua.post")]
        [HttpPost]
        public async Task<IActionResult> Sua(DanhSachTinhXeDiQua _lo_trinh_xe, int id, int id_lo_trinh)
        {
            if (id != _lo_trinh_xe.idNhaXe && id_lo_trinh != _lo_trinh_xe.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var lo_trinh_xe = db.DanhSachTinhXeDiQua.Find(id_lo_trinh);

                if (lo_trinh_xe != null)
                {
                    lo_trinh_xe.idNhaXe = _lo_trinh_xe.idNhaXe;
                    lo_trinh_xe.idTinh = _lo_trinh_xe.idTinh;
                    lo_trinh_xe.thuTu = _lo_trinh_xe.thuTu;
                    lo_trinh_xe.giaVe = _lo_trinh_xe.giaVe;

                    db.Entry(lo_trinh_xe).State = EntityState.Modified;
                    await db.SaveChangesAsync();

                    TempData["success"] = "Sửa thành công";

                    return RedirectToAction("Sua");
                }

                return NotFound();
            }
            else
            {
                TempData["error"] = "Sửa thất bại";
            }

            return View(_lo_trinh_xe);
        }

        [Route("{id:int}/xoa/{id_lo_trinh:int}", Name = "lo_trinh_xe.xoa")]
        [HttpPost]
        public async Task<IActionResult> XoaLoTrinhXe(int id, int id_lo_trinh)
        {
            var lo_trinh_xe = await db.DanhSachTinhXeDiQua.Where(s => s.id == id_lo_trinh).Where(s => s.idNhaXe == id).FirstAsync();
            if (lo_trinh_xe != null)
            {
                db.DanhSachTinhXeDiQua.Remove(lo_trinh_xe);
                await db.SaveChangesAsync();

                TempData["success"] = "Xóa thành công";

                return RedirectToAction("IndexLoTrinhXe", new { id = id});
            }

            return NotFound();
        }
    }
}
