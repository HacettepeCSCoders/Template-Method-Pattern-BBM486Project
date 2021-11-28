using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract;

namespace Service.Concrete
{
    public class SystemAnalystManager:ISystemAnalystService
    { 
        ISystemAnalystDal _systemAnalystDal;
        private SystemAnalystWageCalculator _systemAnalystWageCalculator = new SystemAnalystWageCalculator();

        public SystemAnalystManager(ISystemAnalystDal systemAnalystDal)
        {
            _systemAnalystDal = systemAnalystDal;
        }

        public List<SystemAnalyst> GetAll()
        {
            return _systemAnalystDal.GetAll();
        }

        public List<SystemAnalystDto> GetSystemAnalystDetails()
        {
            return _systemAnalystDal.GetSystemAnalystDetails();
        }

        public void Add(SystemAnalyst systemAnalyst)
        {
            _systemAnalystDal.Add(systemAnalyst);
        }

        public void Update(SystemAnalyst systemAnalyst)
        {
            _systemAnalystDal.Update(systemAnalyst);
        }

        public void Delete(SystemAnalyst systemAnalyst)
        {
            _systemAnalystDal.Delete(systemAnalyst);
        }

        public SystemAnalyst GetById(int systemAnalystId)
        {
            return _systemAnalystDal.Get(j => j.Id == systemAnalystId);
        }
    }
}