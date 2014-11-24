using StoreCMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace StoreCMS.Models
{
    public class SubDepartment
    {
        [Required]
        public int DeptId { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public string DepartmentDiscription { get; set; }

        public List<Product> products { get; set; }

    }
}