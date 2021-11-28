using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class JuniorSoftwareDeveloperManager:IJuniorSoftwareDeveloperService
    {
        IJuniorSoftwareDeveloperDal _juniorSoftwareDeveloperDal;

        private JuniorSoftwareDeveloperWageCalculator _juniorSoftwareDeveloperWageCalculator =
            new JuniorSoftwareDeveloperWageCalculator();

        public JuniorSoftwareDeveloperManager(IJuniorSoftwareDeveloperDal juniorSoftwareDeveloperDal)
        {
            _juniorSoftwareDeveloperDal = juniorSoftwareDeveloperDal;
        }
        
        public List<JuniorSoftwareDeveloper> GetAll()
        {
            return _juniorSoftwareDeveloperDal.GetAll();
        }

        public List<JuniorSoftwareDeveloperDto> GetJuniorSoftwareDeveloperDetails()
        {
            return _juniorSoftwareDeveloperDal.GetJuniorSoftwareDeveloperDetails();
        }

        public void Add(JuniorSoftwareDeveloper juniorSoftwareDeveloper)
        {
            _juniorSoftwareDeveloperDal.Add(juniorSoftwareDeveloper);
        }

        public void Update(JuniorSoftwareDeveloper juniorSoftwareDeveloper)
        {
            _juniorSoftwareDeveloperDal.Update(juniorSoftwareDeveloper);
        }

        public void Delete(JuniorSoftwareDeveloper juniorSoftwareDeveloper)
        {
            _juniorSoftwareDeveloperDal.Delete(juniorSoftwareDeveloper);
        }

        public JuniorSoftwareDeveloper GetById(int juniorSoftwareDeveloperId)
        {
            return _juniorSoftwareDeveloperDal.Get(j=>j.Id==juniorSoftwareDeveloperId);
        }
        public void UpdateWage(JuniorSoftwareDeveloper juniorSoftwareDeveloper, int workHour)
        {
            juniorSoftwareDeveloper.Wage = _juniorSoftwareDeveloperWageCalculator.Calculate(workHour);
            _juniorSoftwareDeveloperDal.Update(juniorSoftwareDeveloper);
        }
    }
}