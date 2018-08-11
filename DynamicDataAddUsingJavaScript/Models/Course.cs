using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDataAddUsingJavaScript.Models
{
    public class Course
    {
        public Course(int id, string name, int did)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentId = did;
        }

        public Course()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Course> Courses { get; set; } 

        public List<Course> GetCourses()
        {
            List<Course> CourseList=new List<Course>();
            CourseList.Add(new Course(Id=1,Name="Math",DepartmentId=1));
            CourseList.Add(new Course(Id = 2, Name = "Computer Architecture", DepartmentId = 2));
            CourseList.Add(new Course(Id = 3, Name = "Software Engineering", DepartmentId = 1));
            CourseList.Add(new Course(Id = 4, Name = "Testing", DepartmentId = 3));
            CourseList.Add(new Course(Id = 5, Name = "Basic Electronics", DepartmentId = 4));
            return CourseList;
        } 
    }
}