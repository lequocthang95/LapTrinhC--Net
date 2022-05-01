using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemo2.Models;

namespace WebDemo2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (login != null)
            {
                if ((login.username == "QuocThang")&&(login.password =="deptrai"))
                {
                    Session["user"] = login;
                    ViewBag.Message = "";
                }
                else
                {
                    ViewBag.Message = "Tài khoản đăng nhập sai! Vui lòng nhập lại.";
                }
            }
            return View("Index");
        }
        public ActionResult LogOut()
        {
              if (Session["user"] != null)
                {
                    Session.Remove("user");
                }                
            return View("Index");
        }
        [HttpPost]
        public ActionResult Register(Register register)
        {
            if (register.email!=null&&register.username2!=null&&register.password!=null)
            {
                HttpContext.Application["register"]=register;
            }
            else
            {
                ViewBag.MesRegister = "Đăng ký thất bại. Vui lòng nhập lại đúng và đầy đủ.";
            }
            return View("Index");
        }
        public ActionResult RegisterMore()
        {
            if (HttpContext.Application["register"] != null)
            {
                HttpContext.Application.Remove("register");
            }
            return View("Index");
        }
    }
}