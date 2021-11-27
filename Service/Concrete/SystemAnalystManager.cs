using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class SystemAnalystManager:ISystemAnalystService
    { 
        ISystemAnalystDal _systemAnalystDal;

        public SystemAnalystManager(ISystemAnalystDal systemAnalystDal)
        {
            _systemAnalystDal = systemAnalystDal;
        }

        public List<SystemAnalyst> GetAll()
        {
            return _systemAnalystDal.GetAll();
        }

        public void Add(SystemAnalyst systemAnalyst)
        {
            throw new System.NotImplementedException();
        }

        public void Update(SystemAnalyst systemAnalyst)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(SystemAnalyst systemAnalyst)
        {
            throw new System.NotImplementedException();
        }

        public SystemAnalyst GetById(int systemAnalystId)
        {
            throw new System.NotImplementedException();
        }
    }
}