using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract.Services
{
    public interface IProjectManagerService
    {
        List<ProjectManager> GetAll();
        void Add(ProjectManager projectManager);
        void Update(ProjectManager projectManager);
        void Delete(ProjectManager projectManager);
        ProjectManager GetById(int projectManagerId);
        void UpdateWage(ProjectManager projectManager, int workHour);
    }
}