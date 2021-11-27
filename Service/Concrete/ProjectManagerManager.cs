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
    }
}