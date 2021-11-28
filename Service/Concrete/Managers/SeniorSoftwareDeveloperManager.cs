using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class SeniorSoftwareDeveloperManager:ISeniorSoftwareDeveloperService
    {
        ISeniorSoftwareDeveloperDal _seniorSoftwareDeveloperDal;

        private SeniorSoftwareDeveloperWageCalculator _seniorSoftwareDeveloperWageCalculator =
            new SeniorSoftwareDeveloperWageCalculator();
        
        public SeniorSoftwareDeveloperManager(ISeniorSoftwareDeveloperDal seniorSoftwareDeveloperDal)
        {
            _seniorSoftwareDeveloperDal = seniorSoftwareDeveloperDal;
        }
        
        public List<SeniorSoftwareDeveloper> GetAll()
        { 
            return _seniorSoftwareDeveloperDal.GetAll();
        }

        public List<SeniorSoftwareDeveloperDto> GetSeniorSoftwareDeveloperDetails()
        {
            return _seniorSoftwareDeveloperDal.GetSeniorSoftwareDeveloperDetails();
        }

        public void Add(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            _seniorSoftwareDeveloperDal.Add(seniorSoftwareDeveloper);
        }

        public void Update(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            _seniorSoftwareDeveloperDal.Update(seniorSoftwareDeveloper);
        }

        public void Delete(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            _seniorSoftwareDeveloperDal.Delete(seniorSoftwareDeveloper);
        }

        public SeniorSoftwareDeveloper GetById(int seniorSoftwareDeveloperId)
        {
            return _seniorSoftwareDeveloperDal.Get(j=>j.Id==seniorSoftwareDeveloperId);
        }
        public void UpdateWage(SeniorSoftwareDeveloper seniorSoftwareDeveloper, int workHour)
        {
            seniorSoftwareDeveloper.Wage = _seniorSoftwareDeveloperWageCalculator.Calculate(workHour);
            _seniorSoftwareDeveloperDal.Update(seniorSoftwareDeveloper);
        }
    }
}