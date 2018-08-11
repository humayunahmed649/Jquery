using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using DynamicDataAddUsingJavaScript.Models;

namespace DynamicDataAddUsingJavaScript.Controllers
{
    public class SemesterController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            Department department=new Department();
            Course course=new Course();
            Semester semester=new Semester();
            semester.Departments = department.GetDepartments();
            ViewBag.DepartmentDropDown=new SelectList(semester.Departments,"Id","Name");
            semester.Courses = course.GetCourses();
            ViewBag.CourseDropDown = new SelectListItem[] { new SelectListItem() { Value = "", Text = "Select..." } };
            return View();
        }
        [HttpPost]
        public ActionResult Index(Semester semester)
        {

            Department department = new Department();
            Course course = new Course();
            Semester sem=new Semester();
            sem.Departments = department.GetDepartments();
            ViewBag.DepartmentDropDown = new SelectList(sem.Departments, "Id", "Name");
            sem.Courses = course.GetCourses();
            ViewBag.CourseDropDown = new SelectListItem[] { new SelectListItem() { Value = "", Text = "Select..." } };
            return View();
        }
    }
}