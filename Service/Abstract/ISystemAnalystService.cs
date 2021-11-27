using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract
{
    public interface ISystemAnalystService
    {
        List<SystemAnalyst> GetAll();
        List<SystemAnalystDto> GetSystemAnalystDetails();
        void Add(SystemAnalyst systemAnalyst);
        void Update(SystemAnalyst systemAnalyst);
        void Delete(SystemAnalyst systemAnalyst);
        SystemAnalyst GetById(int systemAnalystId);
    }
}