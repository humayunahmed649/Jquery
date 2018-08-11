using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDataAddUsingJavaScript.Models
{
    public class Department
    {
        public int  Id  { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; } 

        public Department(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Department()
        {
        }

        public List<Department> GetDepartments()
        {
            List<Department> departmentList = new List<Department>();
            departmentList.Add(new Department(Id=1, Name="Computer Science And Engineering"));
            departmentList.Add(new Department(Id=2, Name = "Bachelor of Study"));
            departmentList.Add(new Department(Id=3, Name = "Bachelor of Arts"));
            departmentList.Add(new Department(Id=4, Name = "Bachelor Of Science"));
            return departmentList;
        } 
    }
}