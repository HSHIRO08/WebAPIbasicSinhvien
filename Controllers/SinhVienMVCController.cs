using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Quanlysinhvien.Models;
using Quanlysinhvien.Services;

namespace Quanlysinhvien.Controllers
{
    public class SinhVienMVCController : Controller
    {
        private readonly ISinhVienService _sinhVienService = new SinhVienService();

        /// <summary>
        /// Trang danh sách sinh viên
        /// </summary>
        public ActionResult Index()
        {
            try
            {
                var danhSach = _sinhVienService.GetAllSinhVien();
                return View(danhSach);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "L?i khi t?i danh sách: " + ex.Message;
                return View(new List<SinhVien>());
            }
        }

        /// <summary>
        /// Trang t?o sinh viên m?i
        /// </summary>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// L?u sinh viên m?i
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SinhVien sinhVien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _sinhVienService.CreateSinhVien(sinhVien);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "L?i: " + ex.Message;
            }
            return View(sinhVien);
        }

        /// <summary>
        /// Trang ch?nh s?a sinh viên
        /// </summary>
        public ActionResult Edit(int id)
        {
            try
            {
                var sinhVien = _sinhVienService.GetSinhVienById(id);
                if (sinhVien == null)
                    return HttpNotFound();

                return View(sinhVien);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "L?i: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        /// <summary>
        /// L?u thay ??i sinh viên
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SinhVien sinhVien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _sinhVienService.UpdateSinhVien(id, sinhVien);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "L?i: " + ex.Message;
            }
            return View(sinhVien);
        }

        /// <summary>
        /// Trang xác nh?n xóa
        /// </summary>
        public ActionResult Delete(int id)
        {
            try
            {
                var sinhVien = _sinhVienService.GetSinhVienById(id);
                if (sinhVien == null)
                    return HttpNotFound();

                return View(sinhVien);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "L?i: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        /// <summary>
        /// Xác nh?n xóa
        /// </summary>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _sinhVienService.DeleteSinhVien(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "L?i: " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
