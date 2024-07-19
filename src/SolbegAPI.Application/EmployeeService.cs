using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SolbegAPI
{
    public class EmployeeService : 
        CrudAppService<
            Employee,
            EmployeeDto,
            Guid,
            PagedAndSortedResultRequestDto,
            PostEmployeeDto>,
        IEmployeeService
    {
        public EmployeeService(IRepository<Employee, Guid> repository)
            : base(repository)
        { 
        }

        public async Task<PagedResultDto<EmployeeDto>> GetDeletedEmployees()
        {
            var queryable = await Repository.GetQueryableAsync();

            var query = from Employee in queryable
                        where Employee.IsDeleted == true
                        select new { Employee };

            var queryResult =  await AsyncExecuter.ToListAsync(query);

            var pendingsReturn = queryResult.Select(x =>
            {
                var pendingsReturn = ObjectMapper.Map<Employee, EmployeeDto>(x.Employee);
                return pendingsReturn;

            }).ToList();

            var totalCount = queryResult.Count;

            return new PagedResultDto<EmployeeDto>(
                totalCount,
                pendingsReturn
            );

        }
    }
}
