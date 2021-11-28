using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Service.Abstract;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    
    public class ProjectManagerManager:IProjectManagerService
    {
        IProjectManagerDal _projectManagerDal;
        private ProjectManagerWageCalculator _projectManagerWageCalculator = new ProjectManagerWageCalculator();
        
        public ProjectManagerManager(IProjectManagerDal projectManagerDal)
        {
            _projectManagerDal = projectManagerDal;
        }
       
        public List<ProjectManager> GetAll()
        {
            return _projectManagerDal.GetAll();
        }

        public void Add(ProjectManager projectManager)
        {
            _projectManagerDal.Add(projectManager);
        }

        public void Update(ProjectManager projectManager)
        {
            _projectManagerDal.Update(projectManager);
        }

        public void Delete(ProjectManager projectManager)
        {
            _projectManagerDal.Delete(projectManager);
        }

        public ProjectManager GetById(int projectManagerId)
        {
            return _projectManagerDal.Get(j=>j.Id==projectManagerId);
        }
        public void UpdateWage(ProjectManager projectManager, int workHour)
        {
            projectManager.Wage = _projectManagerWageCalculator.Calculate(workHour);
            _projectManagerDal.Update(projectManager);
        }
    }
}