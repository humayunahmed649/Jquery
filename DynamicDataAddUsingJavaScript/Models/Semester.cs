using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDataAddUsingJavaScript.Models
{
    public class Semester
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        
        public List<Department> Departments { get; set; } 
        public List<Course> Courses { get; set; } 
    }
}