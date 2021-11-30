using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class SoftwareDeveloperManager : ISoftwareDeveloperService
    {
        private readonly ISoftwareDeveloperDal _softwareDeveloperDal;

        private readonly SoftwareDeveloperWageCalculator
            _softwareDeveloperWageCalculator = new SoftwareDeveloperWageCalculator();

        public SoftwareDeveloperManager(ISoftwareDeveloperDal softwareDeveloperDal)
        {
            _softwareDeveloperDal = softwareDeveloperDal;
        }

        public List<SoftwareDeveloper> GetAll()
        {
            return _softwareDeveloperDal.GetAll();
        }

        public List<SoftwareDeveloperDto> GetSoftwareDeveloperDetails()
        {
            return _softwareDeveloperDal.GetSoftwareDeveloperDetails();
        }

        public void Add(SoftwareDeveloper softwareDeveloper)
        {
            _softwareDeveloperDal.Add(softwareDeveloper);
        }

        public void Update(SoftwareDeveloper softwareDeveloper)
        {
            _softwareDeveloperDal.Update(softwareDeveloper);
        }

        public void Delete(SoftwareDeveloper softwareDeveloper)
        {
            _softwareDeveloperDal.Delete(softwareDeveloper);
        }

        public SoftwareDeveloper GetById(int softwareDeveloperId)
        {
            return _softwareDeveloperDal.Get(j => j.Id == softwareDeveloperId);
        }

        public void UpdateWage(SoftwareDeveloper softwareDeveloper, int workHour)
        {
            softwareDeveloper.Wage = _softwareDeveloperWageCalculator.Calculate(workHour);
            _softwareDeveloperDal.Update(softwareDeveloper);
        }
    }
}