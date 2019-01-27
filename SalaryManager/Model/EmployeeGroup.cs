using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SalaryManager.Model
{
    public class EmployeeGroup
    {
        public int EmployeeGroupId { get; set; }
        public string EmployeeGroupName { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ChiefId { get; set; }
        public Chief Chief { get; set; }
    }
}
