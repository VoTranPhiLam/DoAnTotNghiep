using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTemplate.Models
{
    public class DatSan
    {
        public string hoTen { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage = "Số điện thoại là trường bắt buộc.")]
        [RegularExpression(@"^(\+\d{1,3}[- ]?)?\d{10}$", ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string soDienThoai { get; set; }
        public string ma_San { get; set; }
        public DateTime gioBatDau { get; set; }
        public DateTime gioKetThuc { get; set; }
    }
}