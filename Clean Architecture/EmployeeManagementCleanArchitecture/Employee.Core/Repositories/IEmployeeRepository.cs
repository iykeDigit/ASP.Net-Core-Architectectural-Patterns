using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        //custom operations here
        Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname);
    }
}
