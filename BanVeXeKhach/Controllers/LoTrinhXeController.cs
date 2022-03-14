using BanVeXeKhach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Controllers
{
    //[Route("lo-trinh-xe")]
    public class LoTrinhXeController : Controller
    {
        private PostgreSQLContext db;

        public LoTrinhXeController(PostgreSQLContext _db)
        {
            db = _db;
        }

        [Route("", Name = "lo_trinh_xe.index")]
        public IActionResult Index()
        {
            return View(db.DanhSachTinhXeDiQua.ToList());
        }

        //[Route("them", Name = "lo_trinh_xe.them.get")]
        //[HttpGet]
        //public IActionResult Them()
        //{
        //    return View();
        //}

        //[Route("them", Name = "lo_trinh_xe.them.post")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Them(DanhSachTinhXeDiQua ds_tinh_xe_di_qua)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.DanhSachTinhXeDiQua.Add(ds_tinh_xe_di_qua);
        //        db.SaveChanges();
        //        TempData["success"] = "Thêm thành công";

        //        return RedirectToAction("Them");
        //    }
        //    else
        //    {
        //        TempData["error"] = "Thêm thất bại";

        //        return View(ds_tinh_xe_di_qua);
        //    }
        //}

        //[Route("sua/{id_nha_xe:int}/{id_tinh:int}", Name = "lo_trinh_xe.sua.get")]
        //[HttpGet]
        //public IActionResult Sua(int id_nha_xe, int id_tinh)
        //{
        //    var lo_trinh_xe = db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == id_nha_xe).Where(s => s.idTinh == id_tinh).First();
        //    if (lo_trinh_xe != null)
        //    {
        //        return View(lo_trinh_xe);
        //    }

        //    return NotFound();
        //}

        //[Route("sua/{id_nha_xe:int}/{id_tinh:int}", Name = "lo_trinh_xe.sua.post")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Sua(DanhSachTinhXeDiQua _ds_tinh_xe_di_qua, int id_nha_xe, int id_tinh)
        //{
        //    if (id_nha_xe != _ds_tinh_xe_di_qua.idNhaXe && id_tinh != _ds_tinh_xe_di_qua.idTinh)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        var ds_tinh_xe_di_qua = db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == id_nha_xe).Where(s => s.idTinh == id_tinh).First();

        //        if (ds_tinh_xe_di_qua != null)
        //        {
        //            ds_tinh_xe_di_qua.idNhaXe = _ds_tinh_xe_di_qua.idNhaXe;
        //            ds_tinh_xe_di_qua.idTinh = _ds_tinh_xe_di_qua.idTinh;
        //            ds_tinh_xe_di_qua.thuTu = _ds_tinh_xe_di_qua.thuTu;
        //            ds_tinh_xe_di_qua.giaVe = _ds_tinh_xe_di_qua.giaVe;

        //            db.Entry(ds_tinh_xe_di_qua).State = EntityState.Modified;
        //            db.SaveChanges();

        //            TempData["success"] = "Sửa thành công";

        //            return RedirectToAction("Sua");
        //        }

        //        return NotFound();
        //    }
        //    else
        //    {
        //        TempData["error"] = "Sửa thất bại";
        //    }

        //    return View(_ds_tinh_xe_di_qua);
        //}

        //[Route("xoa/{id_nha_xe:int}/{id_tinh:int}", Name = "lo_trinh_xe.xoa")]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Xoa(int id_nha_xe, int id_tinh)
        //{
        //    var lo_trinh_xe = db.DanhSachTinhXeDiQua.Where(s => s.idNhaXe == id_nha_xe).Where(s => s.idTinh == id_tinh).First();
        //    if (lo_trinh_xe != null)
        //    {
        //        db.DanhSachTinhXeDiQua.Remove(lo_trinh_xe);
        //        db.SaveChanges();

        //        TempData["success"] = "Xóa thành công";

        //        return RedirectToAction("Index");
        //    }

        //    return NotFound();
        //}
    }
}
