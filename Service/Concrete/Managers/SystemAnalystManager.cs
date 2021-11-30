using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class SystemAnalystManager : ISystemAnalystService
    {
        private readonly ISystemAnalystDal _systemAnalystDal;
        private readonly SystemAnalystWageCalculator _systemAnalystWageCalculator = new SystemAnalystWageCalculator();

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

        public void UpdateWage(SystemAnalyst systemAnalyst, int workHour)
        {
            systemAnalyst.Wage = _systemAnalystWageCalculator.Calculate(workHour);
            _systemAnalystDal.Update(systemAnalyst);
        }
    }
}