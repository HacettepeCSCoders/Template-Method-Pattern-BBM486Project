using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface IProjectManagerService
    {
        List<ProjectManager> GetAll();
    }
}