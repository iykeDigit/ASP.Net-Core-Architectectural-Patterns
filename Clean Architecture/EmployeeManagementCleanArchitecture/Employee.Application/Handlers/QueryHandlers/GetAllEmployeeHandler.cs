using EmployeeManagement.Application.Queries;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Handlers.QueryHandlers
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public GetAllEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<List<Core.Entities.Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Employee>)await _employeeRepo.GetAllAsync();
        }
    }
}
