using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTemplate.Models;

namespace TestTemplate.Controllers
{
    public class DangKyController : Controller
    {
        // GET: DangKy
        QLDSEntities db = new QLDSEntities();
        private static int MaKH = 1; // Biến đếm mã khách hàng
        private static int MaTK = 1; // Biến đếm mã khách hàng
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public JsonResult DangKy(DangKy model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Thông tin đăng ký không hợp lệ." });
            }

            var check_userName = db.user_KhachHang.Where(u => u.username == model.userName).SingleOrDefault();
            if (check_userName != null)
            {
                TempData["LoiUserName"] = "Tên đăng nhập đã được sử dụng!";
                return Json(new { success = false, message = "Tên đăng nhập đã được sử dụng!" });
            }
            else
            {
                // Lưu khách hàng vào cơ sở dữ liệu
                var lastCustomer = db.user_KhachHang.OrderByDescending(kh => kh.MaKH).FirstOrDefault();
                if (lastCustomer != null)
                {
                    MaKH = int.Parse(lastCustomer.MaKH) + 1;
                }

                string makh = $"{MaKH:D3}";
                MaKH++;
                user_KhachHang khachHang = new user_KhachHang()
                {
                    MaKH = makh,
                    HoTen = model.hoTen,
                    SoDienThoai = model.soDienThoai,
                    Email = model.email,
                    username = model.userName,
                    password = model.password
                };
                db.user_KhachHang.Add(khachHang);

                // Lưu tài khoản khách hàng
                var checkMTK = db.TaiKhoans.OrderByDescending(tk => tk.MaTK).FirstOrDefault();
                if (checkMTK != null)
                {
                    MaTK = int.Parse(checkMTK.MaTK) + 1;
                }

                string maTK = $"{MaTK:D3}";
                MaTK++;
                TaiKhoan taiKhoan = new TaiKhoan()
                {
                    MaTK = maTK,
                    MaKH = khachHang.MaKH,
                    username = model.userName,
                    password = model.password
                };

                db.TaiKhoans.Add(taiKhoan);
                db.SaveChanges();

                return Json(new { success = true, message = "Đăng ký thành công!" });
            }
        }



    }
}