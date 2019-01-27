using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SalaryManager.Model
{
    public class Chief
    {
        public int ChiefId { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
        public ICollection<EmployeeGroup> EmployeeGroups { get; set; }
    }
}
