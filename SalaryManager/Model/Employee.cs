using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SalaryManager.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDateOfEmployment { get; set; }
        public int EmployeeBaseSalaryRate { get; set; }

        public ICollection<EmployeeGroup> EmployeeGroups { get; set; }

        public int ChiefId { get; set; }
        public Chief Chief { get; set; }
    }
}
