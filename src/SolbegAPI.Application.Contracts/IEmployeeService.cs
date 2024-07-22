using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SolbegAPI
{
    
    public interface IEmployeeService :
        ICrudAppService<
            EmployeeDto,
            Guid,
            PagedAndSortedResultRequestDto,
            PostEmployeeDto>
    {
        public Task<PagedResultDto<EmployeeDto>> GetDeletedEmployees();
    }
}
