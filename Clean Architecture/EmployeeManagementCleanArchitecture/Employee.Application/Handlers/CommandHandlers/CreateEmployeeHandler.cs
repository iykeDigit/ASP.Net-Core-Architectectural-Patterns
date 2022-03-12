using EmployeeManagement.Application.Commands;
using EmployeeManagement.Application.Mappers;
using EmployeeManagement.Application.Responses;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepo;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntity = EmployeeMapper.Mapper.Map<Employee>(request);
            if(employeeEntity is null) 
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _employeeRepo.AddAsync(employeeEntity);
            var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);
            return employeeResponse;
        }
    }
}
