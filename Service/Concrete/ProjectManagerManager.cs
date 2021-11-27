using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    
    public class ProjectManagerManager:IProjectManagerService
    {
        IProjectManagerDal _projectManagerDal;

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
            throw new System.NotImplementedException();
        }

        public void Update(ProjectManager projectManager)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(ProjectManager projectManager)
        {
            throw new System.NotImplementedException();
        }

        public ProjectManager GetById(int projectManagerId)
        {
            throw new System.NotImplementedException();
        }
    }
}