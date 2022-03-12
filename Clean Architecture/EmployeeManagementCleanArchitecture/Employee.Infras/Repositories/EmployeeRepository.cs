using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Repositories;
using EmployeeManagement.Infras.Data;
using EmployeeManagement.Infras.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infras.Repositories
{
   public class EmployeeRepository: Repository<EmployeeManagement.Core.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext employeeContext) : base(employeeContext) { }
        public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByLastName(string lastName) 
        {
            return await _employeeContext.Employees.Where(m => m.LastName == lastName).ToListAsync();
        }
    }
}
