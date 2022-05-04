using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDemo2.Data;
using WebDemo2.Models;

namespace WebDemo2.Controllers
{
    public class StudentsController : Controller
    {
       
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
           
                HttpCookie cookie = Request.Cookies.Get("CreateStudent");
                string dateValue = cookie["birthday"];
                DateTime parsedDate = DateTime.Parse(dateValue);              
                students.Add(new Student
                {
                    Id = cookie["id"],
                    FullName = cookie["name"],
                    Birthday = parsedDate
                });       
            return students;
        }
        // GET: Students
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {           
            HttpCookie cookie = new HttpCookie("CreateStudent");
            cookie.Values.Add("id", student.Id);
            cookie.Values.Add("name", student.FullName);
            cookie.Values.Add("birthday",student.Birthday.ToString("MM-dd-yyyy"));
            
            Response.Cookies.Add(cookie);
            ViewBag.Student = GetStudents();
            return View("Index");
        }             
    }
}
