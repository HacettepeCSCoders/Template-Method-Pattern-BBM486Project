using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ISystemAnalystService
    {
        List<SystemAnalyst> GetAll();
        
        void Add(SystemAnalyst systemAnalyst);
        void Update(SystemAnalyst systemAnalyst);
        void Delete(SystemAnalyst systemAnalyst);
        SystemAnalyst GetById(int systemAnalystId);
    }
}