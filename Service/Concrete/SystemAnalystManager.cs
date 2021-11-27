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
    }
}