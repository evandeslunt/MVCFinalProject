using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using StoreCMS.Models;


namespace StoreCMS.Models
{
    public class Department
    {
        [Required]
        public int DeptId { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public string DepartmentDescription { get; set; }

        public List<Product> Products { get; set; }

        public List<SubDepartment> SubDepartments { get; set; }

    }
}