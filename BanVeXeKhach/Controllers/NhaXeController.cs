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
        public IActionResult Index()
        {
            var nha_xe = db.NhaXe.Include(s => s.DanhSachTinhXeDiQua).ToList();
            
            return View(nha_xe);
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
        public IActionResult Sua(int id)
        {
            var tinh = db.NhaXe.Find(id);
            if (tinh != null)
            {
                return View(tinh);
            }

            return NotFound();
        }

        [Route("sua/{id:int}", Name = "nha_xe.sua.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
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
        public IActionResult IndexLoTrinhXe(int id)
        {
            NhaXe nha_xe = db.NhaXe.Find(id);
            if (nha_xe != null)
            {
                ViewBag.NhaXe = nha_xe;

                return View(db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == id).OrderBy(s => s.thuTu).Include(s => s.NhaXe).Include(s => s.Tinh).AsNoTracking().ToList());
            }

            return NotFound();
        }

        [Route("{id:int}/them", Name = "nha_xe.lo_trinh.them.get")]
        [HttpGet]
        public IActionResult ThemLoTrinhXe(int id)
        {
            NhaXe nha_xe = db.NhaXe.Find(id);
            if (nha_xe != null)
            {
                ViewBag.NhaXe = nha_xe;
                ViewBag.DSTinh = getDSTinh();

                return View();
            }

            return NotFound();
        }

        [Route("{id:int}/them", Name = "nha_xe.lo_trinh.them.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ThemLoTrinhXe(DanhSachTinhXeDiQua lo_trinh_xe, int id)
        {
            if (id != lo_trinh_xe.idNhaXe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                DanhSachTinhXeDiQua lo_trinh_xe_1 = db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == lo_trinh_xe.idNhaXe).Where(s => s.idTinh == lo_trinh_xe.idTinh).FirstOrDefault();
                DanhSachTinhXeDiQua lo_trinh_xe_2 = db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == lo_trinh_xe.idNhaXe).Where(s => s.thuTu == lo_trinh_xe.thuTu).FirstOrDefault();
                if (lo_trinh_xe_1 == null && lo_trinh_xe_2 == null)
                {
                    db.DanhSachTinhXeDiQua.Add(lo_trinh_xe);
                    await db.SaveChangesAsync();
                    TempData["success"] = "Thêm thành công";

                    return RedirectToAction("ThemLoTrinhXe");
                }
            }

            TempData["error"] = "Thêm thất bại";

            return RedirectToAction("ThemLoTrinhXe");
        }

        [Route("{id:int}/sua/{id_tinh:int}", Name = "nha_xe.lo_trinh.sua.get")]
        [HttpGet]
        public IActionResult SuaLoTrinhXe(int id, int id_tinh)
        {
            NhaXe nha_xe = db.NhaXe.Find(id);
            DanhSachTinhXeDiQua lo_trinh_xe = db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == id).Where(s => s.idTinh == id_tinh).FirstOrDefault();
            if (lo_trinh_xe != null)
            {
                ViewBag.NhaXe = nha_xe;
                ViewBag.DSTinh = new SelectList(db.Tinh, "id", "tenTinh", id_tinh);

                return View(lo_trinh_xe);
            }

            return NotFound();
        }

        [Route("{id:int}/sua/{id_tinh:int}", Name = "nha_xe.lo_trinh_xe.sua.post")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SuaLoTrinhXe(DanhSachTinhXeDiQua lo_trinh_xe, int id, int id_tinh)
        {
            if (id != lo_trinh_xe.idNhaXe && id_tinh != lo_trinh_xe.idTinh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                db.Entry(lo_trinh_xe).State = EntityState.Modified;
                await db.SaveChangesAsync();

                TempData["success"] = "Sửa thành công";

                return RedirectToAction("SuaLoTrinhXe");
            }

            TempData["error"] = "Sửa thất bại";

            return View(lo_trinh_xe);
        }

        [Route("{id:int}/xoa/{id_tinh:int}", Name = "lo_trinh_xe.xoa")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> XoaLoTrinhXe(int id, int id_tinh)
        {
            DanhSachTinhXeDiQua lo_trinh_xe = await db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == id).Where(s => s.idTinh == id_tinh).FirstAsync();
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
