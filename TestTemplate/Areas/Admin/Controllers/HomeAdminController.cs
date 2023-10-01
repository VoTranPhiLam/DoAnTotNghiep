using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TestTemplate.Models;    

namespace TestTemplate.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        QuanLyDatSanEntities db;
        public ActionResult Index()
        {
            if(Session["user"] == null)
                return RedirectToAction("DangNhap");
            else 
                return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string user, string password)
        {
            //Check db

            //Check code
            if(user.ToLower() == "admin" && password == "1234")
            {
                Session["user"] = "admin"; // phiên làm việc;
                return RedirectToAction("Index");
            }    
            else
            {
                TempData["error"] = "Tên đăng nhập hoặc mật khẩu không đúng !";
                return View();
            }
        }

        public ActionResult DangXuat()
        {
            //xóa session
            Session.Remove("user");
            // Xóa authentication form
            FormsAuthentication.SignOut();

            return RedirectToAction("DangNhap");
        }

        public ActionResult DanhSachCoSo()
        {
            //1. Lấy danh sách dữ liệu trong bảng
            db = new QuanLyDatSanEntities();
            List<coso> danhSachCoSo = db.cosoes.ToList();  
            return View(danhSachCoSo);
        }

        public ActionResult DanhSachNhanVien()
        {
            db = new QuanLyDatSanEntities();
            List<NHANVIEN> danhSachNhanVien = db.NHANVIENs.ToList();
            return View(danhSachNhanVien);
        }
    }
}