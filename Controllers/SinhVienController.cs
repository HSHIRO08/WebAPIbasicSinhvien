using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Quanlysinhvien.Models;
using Quanlysinhvien.Services;

namespace Quanlysinhvien.Controllers
{
    /// <summary>
    /// API Controller cho qu?n lý sinh viên
    /// </summary>
    public class SinhVienApiController : ApiController
    {
        private readonly ISinhVienService _sinhVienService = new SinhVienService();

        /// <summary>
        /// L?y danh sách t?t c? sinh viên
        /// GET /api/sinhvienapi
        /// </summary>
        public IHttpActionResult Get()
        {
            try
            {
                var danhSach = _sinhVienService.GetAllSinhVien();
                return Ok(new { success = true, data = danhSach });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// L?y thông tin sinh viên theo ID
        /// GET /api/sinhvienapi/1
        /// </summary>
        public IHttpActionResult Get(int id)
        {
            try
            {
                var sinhVien = _sinhVienService.GetSinhVienById(id);
                if (sinhVien == null)
                    return NotFound();

                return Ok(new { success = true, data = sinhVien });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Thêm sinh viên m?i
        /// POST /api/sinhvienapi
        /// </summary>
        public IHttpActionResult Post([FromBody] SinhVien sinhVien)
        {
            try
            {
                if (sinhVien == null)
                    return BadRequest("D? li?u sinh viên không h?p l?");

                if (string.IsNullOrWhiteSpace(sinhVien.HoTen))
                    return BadRequest("H? tên không ???c ?? tr?ng");

                if (string.IsNullOrWhiteSpace(sinhVien.MaSinhVien))
                    return BadRequest("Mã sinh viên không ???c ?? tr?ng");

                var result = _sinhVienService.CreateSinhVien(sinhVien);
                return Created("api/sinhvienapi/" + result.Id, new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// C?p nh?t thông tin sinh viên
        /// PUT /api/sinhvienapi/1
        /// </summary>
        public IHttpActionResult Put(int id, [FromBody] SinhVien sinhVien)
        {
            try
            {
                if (sinhVien == null)
                    return BadRequest("D? li?u sinh viên không h?p l?");

                if (string.IsNullOrWhiteSpace(sinhVien.HoTen))
                    return BadRequest("H? tên không ???c ?? tr?ng");

                var result = _sinhVienService.UpdateSinhVien(id, sinhVien);
                if (!result)
                    return NotFound();

                var updatedSinhVien = _sinhVienService.GetSinhVienById(id);
                return Ok(new { success = true, data = updatedSinhVien });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Xóa sinh viên
        /// DELETE /api/sinhvienapi/1
        /// </summary>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var result = _sinhVienService.DeleteSinhVien(id);
                if (!result)
                    return NotFound();

                return Ok(new { success = true, message = "Xóa sinh viên thành công" });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
