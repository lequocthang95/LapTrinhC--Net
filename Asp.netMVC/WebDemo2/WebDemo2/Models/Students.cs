using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebDemo2.Models
{
    public class Students
    {
        [DisplayName("Mã sinh viên")]
        public String Id { get; set; }
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        [DisplayName("Họ tên")]
        public string FullName { get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime Birthday { get; set; }
        [DisplayName("Ghi chú")]
        public string Notes { get; set; }
    }
}