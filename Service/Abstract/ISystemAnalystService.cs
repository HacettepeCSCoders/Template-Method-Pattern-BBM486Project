using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ISystemAnalystService
    {
        List<SystemAnalyst> GetAll();
    }
}