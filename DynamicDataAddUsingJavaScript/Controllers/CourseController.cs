using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DynamicDataAddUsingJavaScript.Models;

namespace DynamicDataAddUsingJavaScript.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            Course c=new Course();
            Department d=new Department();
            ViewBag.DepartmentId = new SelectList(d.GetDepartments(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Index(Course course)
        {
            Course c = new Course();
            c.Courses.Add(course);
            Department d = new Department();
            ViewBag.DepartmentId = new SelectList(d.GetDepartments(), "Id", "Name");
            return View();
        }

        public JsonResult GetByDepartment(int? departmentId)
        {
            Course c=new Course();
            if (departmentId == null)
            {
                return null;
            }
            var Courses = c.GetCourses().Where(d => d.DepartmentId == departmentId).ToList();
            return Json(Courses, JsonRequestBehavior.AllowGet);
        }
    }
}